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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskMonitor : AbstractModel
    {
        
        /// <summary>
        /// 演练监控指标ID
        /// </summary>
        [JsonProperty("TaskMonitorId")]
        public long? TaskMonitorId{ get; set; }

        /// <summary>
        /// 监控指标ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricId")]
        public ulong? MetricId{ get; set; }

        /// <summary>
        /// 监控指标对象类型ID
        /// </summary>
        [JsonProperty("TaskMonitorObjectTypeId")]
        public long? TaskMonitorObjectTypeId{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 实例ID列表
        /// </summary>
        [JsonProperty("InstancesIds")]
        public string[] InstancesIds{ get; set; }

        /// <summary>
        /// 中文指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricChineseName")]
        public string MetricChineseName{ get; set; }

        /// <summary>
        /// 单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskMonitorId", this.TaskMonitorId);
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamSimple(map, prefix + "TaskMonitorObjectTypeId", this.TaskMonitorObjectTypeId);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "InstancesIds.", this.InstancesIds);
            this.SetParamSimple(map, prefix + "MetricChineseName", this.MetricChineseName);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

