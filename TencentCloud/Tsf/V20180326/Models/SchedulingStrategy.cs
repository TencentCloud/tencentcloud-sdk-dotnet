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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SchedulingStrategy : AbstractModel
    {
        
        /// <summary>
        /// NONE：不使用调度策略；CROSS_AZ：跨可用区部署
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("NodeScheduleStrategyType")]
        public string NodeScheduleStrategyType{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("NodeScheduleOptions")]
        public CommonOption[] NodeScheduleOptions{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("StrongAffinityList")]
        public CommonOption[] StrongAffinityList{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("WeakAffinityList")]
        public CommonOption[] WeakAffinityList{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("WeakAffinityWeight")]
        public long? WeakAffinityWeight{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("AvailableZoneScatterScheduleType")]
        public string AvailableZoneScatterScheduleType{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("AvailableZoneScatterScheduleRules")]
        public AvailableZoneScatterScheduleRule[] AvailableZoneScatterScheduleRules{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("PodScheduleStrategyType")]
        public string PodScheduleStrategyType{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("CustomPodSchedule")]
        public CustomPodSchedule CustomPodSchedule{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("TolerateScheduleType")]
        public string TolerateScheduleType{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("CustomTolerateSchedules")]
        public CustomTolerateSchedule[] CustomTolerateSchedules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "NodeScheduleStrategyType", this.NodeScheduleStrategyType);
            this.SetParamArrayObj(map, prefix + "NodeScheduleOptions.", this.NodeScheduleOptions);
            this.SetParamArrayObj(map, prefix + "StrongAffinityList.", this.StrongAffinityList);
            this.SetParamArrayObj(map, prefix + "WeakAffinityList.", this.WeakAffinityList);
            this.SetParamSimple(map, prefix + "WeakAffinityWeight", this.WeakAffinityWeight);
            this.SetParamSimple(map, prefix + "AvailableZoneScatterScheduleType", this.AvailableZoneScatterScheduleType);
            this.SetParamArrayObj(map, prefix + "AvailableZoneScatterScheduleRules.", this.AvailableZoneScatterScheduleRules);
            this.SetParamSimple(map, prefix + "PodScheduleStrategyType", this.PodScheduleStrategyType);
            this.SetParamObj(map, prefix + "CustomPodSchedule.", this.CustomPodSchedule);
            this.SetParamSimple(map, prefix + "TolerateScheduleType", this.TolerateScheduleType);
            this.SetParamArrayObj(map, prefix + "CustomTolerateSchedules.", this.CustomTolerateSchedules);
        }
    }
}

