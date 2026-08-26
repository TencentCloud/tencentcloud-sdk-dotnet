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

    public class ModifyAlarmHistoryShieldRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，这里填“monitor”
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 屏蔽策略的Id
        /// </summary>
        [JsonProperty("ShieldId")]
        public string ShieldId{ get; set; }

        /// <summary>
        /// 屏蔽策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// 屏蔽时间类型 FOREVER_SHIELD:永久屏蔽 PERIOD_SHIELD:绝对时间范围屏蔽 LOOP_SHIELD:相对时间范围屏蔽
        /// </summary>
        [JsonProperty("ShieldTimeType")]
        public string ShieldTimeType{ get; set; }

        /// <summary>
        /// 需要屏蔽的策略ID
        /// </summary>
        [JsonProperty("ShieldPolicyId")]
        public string ShieldPolicyId{ get; set; }

        /// <summary>
        /// 命名空间即策略类型
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// 屏蔽对象
        /// </summary>
        [JsonProperty("ShieldObject")]
        public string[] ShieldObject{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 开始时间 相对时间范围:36000 绝对时间范围:1648742400 缺省:0
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间 相对时间范围:72000 绝对时间范围:1649088000 缺省:0
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 循环开始日期 2022/04/01 缺省:0
        /// </summary>
        [JsonProperty("LoopStartDate")]
        public ulong? LoopStartDate{ get; set; }

        /// <summary>
        /// 循环结束日期 2022/04/05 缺省:0
        /// </summary>
        [JsonProperty("LoopEndDate")]
        public ulong? LoopEndDate{ get; set; }

        /// <summary>
        /// 需要屏蔽的告警等级
        /// </summary>
        [JsonProperty("ShieldAlarmLevel")]
        public string ShieldAlarmLevel{ get; set; }

        /// <summary>
        ///  时区，东八区+8，西八区减8，以此类推
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// 告警历史会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ShieldId", this.ShieldId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "ShieldTimeType", this.ShieldTimeType);
            this.SetParamSimple(map, prefix + "ShieldPolicyId", this.ShieldPolicyId);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamArraySimple(map, prefix + "ShieldObject.", this.ShieldObject);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LoopStartDate", this.LoopStartDate);
            this.SetParamSimple(map, prefix + "LoopEndDate", this.LoopEndDate);
            this.SetParamSimple(map, prefix + "ShieldAlarmLevel", this.ShieldAlarmLevel);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

