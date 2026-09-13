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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorMetricBrief : AbstractModel
    {
        
        /// <summary>
        /// 监控指标 ID，创建时无需传入，由服务端生成
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorMetricId")]
        public string MonitorMetricId{ get; set; }

        /// <summary>
        /// 告警的监控对象类型，如工作流、任务等，当前支持 1. WORKFLOW 2. TASK
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmMonitorType")]
        public string AlarmMonitorType{ get; set; }

        /// <summary>
        /// 监控指标列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metrics")]
        public MonitorMetricItem[] Metrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorMetricId", this.MonitorMetricId);
            this.SetParamSimple(map, prefix + "AlarmMonitorType", this.AlarmMonitorType);
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
        }
    }
}

