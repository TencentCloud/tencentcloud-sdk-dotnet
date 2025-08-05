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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduleElasticityConf : AbstractModel
    {
        
        /// <summary>
        /// 是否开启弹性伸缩：true/false
        /// </summary>
        [JsonProperty("ScheduledElasticityEnabled")]
        public bool? ScheduledElasticityEnabled{ get; set; }

        /// <summary>
        /// 调度类型：ONCE（一次性调度），DAILY（每日调度），WEEKLY（每周调度），MONTHLY（每月调度）
        /// </summary>
        [JsonProperty("ScheduleType")]
        public string ScheduleType{ get; set; }

        /// <summary>
        /// 调度日期：WEEKLY传：1~7； MONTHLY传:1~31；其它类型不传
        /// </summary>
        [JsonProperty("ScheduleDays")]
        public long?[] ScheduleDays{ get; set; }

        /// <summary>
        /// 调度时区
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// 弹性伸缩计划
        /// </summary>
        [JsonProperty("ElasticPlans")]
        public ElasticPlan[] ElasticPlans{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduledElasticityEnabled", this.ScheduledElasticityEnabled);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamArraySimple(map, prefix + "ScheduleDays.", this.ScheduleDays);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArrayObj(map, prefix + "ElasticPlans.", this.ElasticPlans);
        }
    }
}

