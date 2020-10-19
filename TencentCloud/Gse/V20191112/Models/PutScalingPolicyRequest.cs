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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 扩缩容配置服务器舰队ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 扩缩容策略名称，最小长度为1，最大长度为1024
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 扩缩容调整值，ScalingAdjustmentType取值PercentChangeInCapacity时，取值范围-99~99
        /// ScalingAdjustmentType取值ChangeInCapacity或ExactCapacity时，最小值要缩容的最多CVM个数，最大值为实际最大的CVM个数限额
        /// </summary>
        [JsonProperty("ScalingAdjustment")]
        public long? ScalingAdjustment{ get; set; }

        /// <summary>
        /// 扩缩容调整类型，取值（ChangeInCapacity，ExactCapacity，PercentChangeInCapacity）
        /// </summary>
        [JsonProperty("ScalingAdjustmentType")]
        public string ScalingAdjustmentType{ get; set; }

        /// <summary>
        /// 扩缩容指标阈值
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }

        /// <summary>
        /// 扩缩容策略比较符，取值：>,>=,<,<=
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public string ComparisonOperator{ get; set; }

        /// <summary>
        /// 单个策略持续时间长度（分钟）
        /// </summary>
        [JsonProperty("EvaluationPeriods")]
        public long? EvaluationPeriods{ get; set; }

        /// <summary>
        /// 扩缩容参与计算的指标名称，PolicyType取值RuleBased，
        /// MetricName取值（AvailableGameServerSessions，AvailableCustomCount，PercentAvailableCustomCount，ActiveInstances，IdleInstances，CurrentPlayerSessions和PercentIdleInstances）；
        /// PolicyType取值TargetBased时，MetricName取值PercentAvailableGameSessions
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 策略类型，取值：TargetBased表示基于目标的策略；RuleBased表示基于规则的策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 扩缩容目标值配置，只有TargetBased类型的策略生效
        /// </summary>
        [JsonProperty("TargetConfiguration")]
        public TargetConfiguration TargetConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ScalingAdjustment", this.ScalingAdjustment);
            this.SetParamSimple(map, prefix + "ScalingAdjustmentType", this.ScalingAdjustmentType);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "ComparisonOperator", this.ComparisonOperator);
            this.SetParamSimple(map, prefix + "EvaluationPeriods", this.EvaluationPeriods);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamObj(map, prefix + "TargetConfiguration.", this.TargetConfiguration);
        }
    }
}

