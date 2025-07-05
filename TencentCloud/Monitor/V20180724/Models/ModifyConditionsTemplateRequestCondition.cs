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

    public class ModifyConditionsTemplateRequestCondition : AbstractModel
    {
        
        /// <summary>
        /// 统计周期
        /// </summary>
        [JsonProperty("CalcPeriod")]
        public string CalcPeriod{ get; set; }

        /// <summary>
        /// 统计方式
        /// </summary>
        [JsonProperty("CalcType")]
        public string CalcType{ get; set; }

        /// <summary>
        /// 持续周期
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public string ContinuePeriod{ get; set; }

        /// <summary>
        /// 指标ID
        /// </summary>
        [JsonProperty("MetricID")]
        public long? MetricID{ get; set; }

        /// <summary>
        /// 统计值
        /// </summary>
        [JsonProperty("CalcValue")]
        public string CalcValue{ get; set; }

        /// <summary>
        /// 告警通知周期
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public string AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// 告警通知方式
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public long? AlarmNotifyType{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CalcPeriod", this.CalcPeriod);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "ContinuePeriod", this.ContinuePeriod);
            this.SetParamSimple(map, prefix + "MetricID", this.MetricID);
            this.SetParamSimple(map, prefix + "CalcValue", this.CalcValue);
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
        }
    }
}

