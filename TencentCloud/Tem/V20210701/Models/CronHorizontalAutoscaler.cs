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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CronHorizontalAutoscaler : AbstractModel
    {
        
        /// <summary>
        /// 定时伸缩策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 策略周期
        /// * * *，三个范围，第一个是天，第二个是月，第三个是周，中间用空格隔开
        /// 例子：
        /// * * * （每天）
        /// * * 0-3 （每周日到周三）
        /// 1,11,21 * *（每个月1号，11号，21号）
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// 定时伸缩策略明细
        /// </summary>
        [JsonProperty("Schedules")]
        public CronHorizontalAutoscalerSchedule[] Schedules{ get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 策略优先级，值越大优先级越高，0为最小值
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArrayObj(map, prefix + "Schedules.", this.Schedules);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

