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

    public class CreateScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 告警触发策略名称。
        /// </summary>
        [JsonProperty("ScalingPolicyName")]
        public string ScalingPolicyName{ get; set; }

        /// <summary>
        /// 告警触发后，期望实例数修改方式。取值 ：<br><li>CHANGE_IN_CAPACITY：增加或减少若干期望实例数</li><li>EXACT_CAPACITY：调整至指定期望实例数</li> <li>PERCENT_CHANGE_IN_CAPACITY：按百分比调整期望实例数</li>
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public string AdjustmentType{ get; set; }

        /// <summary>
        /// 告警触发后，期望实例数的调整值。取值：<br><li>当 AdjustmentType 为 CHANGE_IN_CAPACITY 时，AdjustmentValue 为正数表示告警触发后增加实例，为负数表示告警触发后减少实例 </li> <li> 当 AdjustmentType 为 EXACT_CAPACITY 时，AdjustmentValue 的值即为告警触发后新的期望实例数，需要大于或等于0 </li> <li> 当 AdjustmentType 为 PERCENT_CHANGE_IN_CAPACITY 时，AdjusmentValue 为正数表示告警触发后按百分比增加实例，为负数表示告警触发后按百分比减少实例，单位是：%。
        /// </summary>
        [JsonProperty("AdjustmentValue")]
        public long? AdjustmentValue{ get; set; }

        /// <summary>
        /// 告警监控指标。
        /// </summary>
        [JsonProperty("MetricAlarm")]
        public MetricAlarm MetricAlarm{ get; set; }

        /// <summary>
        /// 冷却时间，单位为秒。默认冷却时间300秒。
        /// </summary>
        [JsonProperty("Cooldown")]
        public ulong? Cooldown{ get; set; }

        /// <summary>
        /// 通知组ID，即为用户组ID集合，用户组ID可以通过[DescribeUserGroup](https://cloud.tencent.com/document/api/378/4404)查询。
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "ScalingPolicyName", this.ScalingPolicyName);
            this.SetParamSimple(map, prefix + "AdjustmentType", this.AdjustmentType);
            this.SetParamSimple(map, prefix + "AdjustmentValue", this.AdjustmentValue);
            this.SetParamObj(map, prefix + "MetricAlarm.", this.MetricAlarm);
            this.SetParamSimple(map, prefix + "Cooldown", this.Cooldown);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
        }
    }
}

