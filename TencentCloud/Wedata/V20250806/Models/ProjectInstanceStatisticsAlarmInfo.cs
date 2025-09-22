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

    public class ProjectInstanceStatisticsAlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警类型 
        /// 
        /// projectFailureInstanceUpwardFluctuationAlarm: 失败实例向上波动告警
        /// 
        /// projectSuccessInstanceDownwardFluctuationAlarm： 成功实例向下波动告警
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// 实例成功数向下波动比例告警阀值；实例失败数向上波动比例告警阀值
        /// </summary>
        [JsonProperty("InstanceThresholdCountPercent")]
        public ulong? InstanceThresholdCountPercent{ get; set; }

        /// <summary>
        /// 累计实例数波动阀值
        /// </summary>
        [JsonProperty("InstanceThresholdCount")]
        public ulong? InstanceThresholdCount{ get; set; }

        /// <summary>
        /// 稳定性次数阈值(防抖动配置统计周期数)
        /// </summary>
        [JsonProperty("StabilizeThreshold")]
        public ulong? StabilizeThreshold{ get; set; }

        /// <summary>
        /// 稳定性统计周期(防抖动配置统计周期数)
        /// </summary>
        [JsonProperty("StabilizeStatisticsCycle")]
        public ulong? StabilizeStatisticsCycle{ get; set; }

        /// <summary>
        /// 是否累计计算,false:连续,true:累计
        /// </summary>
        [JsonProperty("IsCumulant")]
        public bool? IsCumulant{ get; set; }

        /// <summary>
        /// 当日累计实例数;
        /// 当天失败实例数向下波动量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "InstanceThresholdCountPercent", this.InstanceThresholdCountPercent);
            this.SetParamSimple(map, prefix + "InstanceThresholdCount", this.InstanceThresholdCount);
            this.SetParamSimple(map, prefix + "StabilizeThreshold", this.StabilizeThreshold);
            this.SetParamSimple(map, prefix + "StabilizeStatisticsCycle", this.StabilizeStatisticsCycle);
            this.SetParamSimple(map, prefix + "IsCumulant", this.IsCumulant);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
        }
    }
}

