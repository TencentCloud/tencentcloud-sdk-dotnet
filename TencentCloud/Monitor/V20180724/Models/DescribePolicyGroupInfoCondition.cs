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

    public class DescribePolicyGroupInfoCondition : AbstractModel
    {
        
        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricShowName")]
        public string MetricShowName{ get; set; }

        /// <summary>
        /// 数据聚合周期(单位秒)
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 指标id
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// 阈值规则id
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 指标单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

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
        /// 比较类型，1表示大于，2表示大于等于，3表示小于，4表示小于等于，5表示相等，6表示不相等，7表示日同比上涨，8表示日同比下降，9表示周同比上涨，10表示周同比下降，11表示周期环比上涨，12表示周期环比下降
        /// </summary>
        [JsonProperty("CalcType")]
        public long? CalcType{ get; set; }

        /// <summary>
        /// 检测阈值
        /// </summary>
        [JsonProperty("CalcValue")]
        public string CalcValue{ get; set; }

        /// <summary>
        /// 持续多长时间触发规则会告警(单位秒)
        /// </summary>
        [JsonProperty("ContinueTime")]
        public long? ContinueTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricShowName", this.MetricShowName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "CalcValue", this.CalcValue);
            this.SetParamSimple(map, prefix + "ContinueTime", this.ContinueTime);
        }
    }
}

