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

    public class DescribeAlarmHistoryShieldRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，这里填“monitor”
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("ShieldPolicyId")]
        public string ShieldPolicyId{ get; set; }

        /// <summary>
        /// 告警历史维度
        /// </summary>
        [JsonProperty("ShieldObject")]
        public string[] ShieldObject{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 屏蔽策略Id
        /// </summary>
        [JsonProperty("ShieldId")]
        public string ShieldId{ get; set; }

        /// <summary>
        /// 告警等级
        /// </summary>
        [JsonProperty("ShieldAlarmLevel")]
        public string ShieldAlarmLevel{ get; set; }

        /// <summary>
        /// 告警历史会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ShieldPolicyId", this.ShieldPolicyId);
            this.SetParamArraySimple(map, prefix + "ShieldObject.", this.ShieldObject);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "ShieldId", this.ShieldId);
            this.SetParamSimple(map, prefix + "ShieldAlarmLevel", this.ShieldAlarmLevel);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
        }
    }
}

