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

    public class ModifyConditionsTemplateRequestEventCondition : AbstractModel
    {
        
        /// <summary>
        /// 告警通知周期
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        [System.Obsolete]
        public string AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// 告警通知方式
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        [System.Obsolete]
        public string AlarmNotifyType{ get; set; }

        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonProperty("EventID")]
        [System.Obsolete]
        public string EventID{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleID")]
        [System.Obsolete]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 重构后的eventType
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 事件描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

