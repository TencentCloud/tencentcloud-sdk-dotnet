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

    public class CreateAlarmShieldRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模块名，这里填“monitor”</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>屏蔽策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>监控类型</p>
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// <p>命名空间即策略类型</p>
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// <p>屏蔽时间类型 FOREVER_SHIELD:永久屏蔽 PERIOD_SHIELD:绝对时间范围屏蔽 LOOP_SHIELD:相对时间范围屏蔽</p>
        /// </summary>
        [JsonProperty("ShieldTimeType")]
        public string ShieldTimeType{ get; set; }

        /// <summary>
        /// <p>屏蔽对象</p>
        /// </summary>
        [JsonProperty("ShieldObject")]
        public string[] ShieldObject{ get; set; }

        /// <summary>
        /// <p>屏蔽指标 为空则为全部指标</p>
        /// </summary>
        [JsonProperty("ShieldMetric")]
        public string[] ShieldMetric{ get; set; }

        /// <summary>
        /// <p>开始时间 相对时间范围:36000 绝对时间范围:1648742400 缺省:0</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间 相对时间范围:72000 绝对时间范围:1649088000 缺省:0</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>循环开始日期 2022/04/01 缺省:0</p>
        /// </summary>
        [JsonProperty("LoopStartDate")]
        public ulong? LoopStartDate{ get; set; }

        /// <summary>
        /// <p>循环结束日期 2022/04/05 缺省:0</p>
        /// </summary>
        [JsonProperty("LoopEndDate")]
        public ulong? LoopEndDate{ get; set; }

        /// <summary>
        /// <p>需要屏蔽的策略ID</p>
        /// </summary>
        [JsonProperty("ShieldPolicyId")]
        public string ShieldPolicyId{ get; set; }

        /// <summary>
        /// <p>需要屏蔽的告警等级，取值范围Warn,Remind,Serious</p>
        /// </summary>
        [JsonProperty("ShieldAlarmLevel")]
        public string[] ShieldAlarmLevel{ get; set; }

        /// <summary>
        /// <p>屏蔽类型，为OBJNAME是实例屏蔽，为POLICY是策略屏蔽</p>
        /// </summary>
        [JsonProperty("VersionTag")]
        public string VersionTag{ get; set; }

        /// <summary>
        /// <p>屏蔽规则的描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>时区，东八区+8，西八区减8，以此类推</p>
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// <p>屏蔽事件 为空则为全部指标</p>
        /// </summary>
        [JsonProperty("ShieldEvent")]
        public string[] ShieldEvent{ get; set; }

        /// <summary>
        /// <p>是否对指标屏蔽 1=是 0=否</p>
        /// </summary>
        [JsonProperty("ShieldMetricFlag")]
        public long? ShieldMetricFlag{ get; set; }

        /// <summary>
        /// <p>是否对事件屏蔽 1=是 0=否</p>
        /// </summary>
        [JsonProperty("ShieldEventFlag")]
        public long? ShieldEventFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "ShieldTimeType", this.ShieldTimeType);
            this.SetParamArraySimple(map, prefix + "ShieldObject.", this.ShieldObject);
            this.SetParamArraySimple(map, prefix + "ShieldMetric.", this.ShieldMetric);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LoopStartDate", this.LoopStartDate);
            this.SetParamSimple(map, prefix + "LoopEndDate", this.LoopEndDate);
            this.SetParamSimple(map, prefix + "ShieldPolicyId", this.ShieldPolicyId);
            this.SetParamArraySimple(map, prefix + "ShieldAlarmLevel.", this.ShieldAlarmLevel);
            this.SetParamSimple(map, prefix + "VersionTag", this.VersionTag);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "ShieldEvent.", this.ShieldEvent);
            this.SetParamSimple(map, prefix + "ShieldMetricFlag", this.ShieldMetricFlag);
            this.SetParamSimple(map, prefix + "ShieldEventFlag", this.ShieldEventFlag);
        }
    }
}

