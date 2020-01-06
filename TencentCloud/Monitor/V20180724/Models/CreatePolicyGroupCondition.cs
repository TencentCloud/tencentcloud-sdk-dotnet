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

    public class CreatePolicyGroupCondition : AbstractModel
    {
        
        /// <summary>
        /// 指标Id
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// 告警发送收敛类型。0连续告警，1指数告警
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public long? AlarmNotifyType{ get; set; }

        /// <summary>
        /// 告警发送周期单位秒。<0 不触发, 0 只触发一次, >0 每隔triggerTime秒触发一次
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public long? AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// 比较类型，1表示大于，2表示大于等于，3表示小于，4表示小于等于，5表示相等，6表示不相等。如果指标有配置默认比较类型值可以不填。
        /// </summary>
        [JsonProperty("CalcType")]
        public long? CalcType{ get; set; }

        /// <summary>
        /// 比较的值，如果指标不必须CalcValue可不填
        /// </summary>
        [JsonProperty("CalcValue")]
        public float? CalcValue{ get; set; }

        /// <summary>
        /// 数据聚合周期(单位秒)，若指标有默认值可不填
        /// </summary>
        [JsonProperty("CalcPeriod")]
        public long? CalcPeriod{ get; set; }

        /// <summary>
        /// 持续几个检测周期触发规则会告警
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public long? ContinuePeriod{ get; set; }

        /// <summary>
        /// 如果通过模版创建，需要传入模版中该指标的对应RuleId
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "CalcValue", this.CalcValue);
            this.SetParamSimple(map, prefix + "CalcPeriod", this.CalcPeriod);
            this.SetParamSimple(map, prefix + "ContinuePeriod", this.ContinuePeriod);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

