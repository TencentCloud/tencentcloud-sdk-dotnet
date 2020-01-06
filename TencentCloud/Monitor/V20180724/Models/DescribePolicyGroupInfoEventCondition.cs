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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyGroupInfoEventCondition : AbstractModel
    {
        
        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 事件告警规则id
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("EventShowName")]
        public string EventShowName{ get; set; }

        /// <summary>
        /// 告警发送周期单位秒。<0 不触发, 0 只触发一次, >0 每隔triggerTime秒触发一次
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public long? AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// 告警发送收敛类型。0连续告警，1指数告警
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public long? AlarmNotifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "EventShowName", this.EventShowName);
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
        }
    }
}

