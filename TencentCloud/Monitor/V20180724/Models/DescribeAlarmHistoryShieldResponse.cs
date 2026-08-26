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

    public class DescribeAlarmHistoryShieldResponse : AbstractModel
    {
        
        /// <summary>
        /// 告警屏蔽规则的ID
        /// </summary>
        [JsonProperty("ShieldId")]
        public string ShieldId{ get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// 屏蔽策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否开启 1=开启 0=关闭
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 监控类型展示名称
        /// </summary>
        [JsonProperty("MonitorTypeShowName")]
        public string MonitorTypeShowName{ get; set; }

        /// <summary>
        /// 命名空间即策略类型
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// 策略类型展示名称
        /// </summary>
        [JsonProperty("NameSpaceShowName")]
        public string NameSpaceShowName{ get; set; }

        /// <summary>
        /// 屏蔽对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShieldObject")]
        public string[] ShieldObject{ get; set; }

        /// <summary>
        /// 屏蔽指标列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShieldMetric")]
        public ShieldMetric[] ShieldMetric{ get; set; }

        /// <summary>
        /// 屏蔽时间类型 FOREVER_SHIELD:永久屏蔽 PERIOD_SHIELD:绝对时间范围屏蔽 LOOP_SHIELD:相对时间范围屏蔽
        /// </summary>
        [JsonProperty("ShieldTimeType")]
        public string ShieldTimeType{ get; set; }

        /// <summary>
        /// 开始时间 10:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间 20:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 循环开始日期 2022/04/01
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoopStartDate")]
        public ulong? LoopStartDate{ get; set; }

        /// <summary>
        /// 循环结束日期 2022/04/05
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoopEndDate")]
        public ulong? LoopEndDate{ get; set; }

        /// <summary>
        /// NOT_TRIGGERED:未生效 TRIGGERING:生效中 EXPIRED:已过期
        /// </summary>
        [JsonProperty("CurrentStatus")]
        public string CurrentStatus{ get; set; }

        /// <summary>
        /// 需要屏蔽的策略ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShieldPolicyId")]
        public string ShieldPolicyId{ get; set; }

        /// <summary>
        /// 需要屏蔽的告警等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShieldAlarmLevel")]
        public string[] ShieldAlarmLevel{ get; set; }

        /// <summary>
        /// 屏蔽类型，1为维度屏蔽，0为实例名称屏蔽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShieldTag")]
        public string ShieldTag{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 时区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// 告警历史会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShieldId", this.ShieldId);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "MonitorTypeShowName", this.MonitorTypeShowName);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "NameSpaceShowName", this.NameSpaceShowName);
            this.SetParamArraySimple(map, prefix + "ShieldObject.", this.ShieldObject);
            this.SetParamArrayObj(map, prefix + "ShieldMetric.", this.ShieldMetric);
            this.SetParamSimple(map, prefix + "ShieldTimeType", this.ShieldTimeType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LoopStartDate", this.LoopStartDate);
            this.SetParamSimple(map, prefix + "LoopEndDate", this.LoopEndDate);
            this.SetParamSimple(map, prefix + "CurrentStatus", this.CurrentStatus);
            this.SetParamSimple(map, prefix + "ShieldPolicyId", this.ShieldPolicyId);
            this.SetParamArraySimple(map, prefix + "ShieldAlarmLevel.", this.ShieldAlarmLevel);
            this.SetParamSimple(map, prefix + "ShieldTag", this.ShieldTag);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

