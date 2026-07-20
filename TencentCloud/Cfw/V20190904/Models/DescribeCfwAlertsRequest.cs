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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwAlertsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>告警开始时间。可选，格式 YYYY-MM-DD HH:MM:SS；默认查询最近 1 小时。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>告警结束时间。可选，格式 YYYY-MM-DD HH:MM:SS；默认当前时间。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>告警严重级别过滤。可选；枚举 low、middle、high。</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>流量方向过滤。可选；枚举 outbound 出站、inbound 入站、lateral 横向。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// <p>处置状态过滤。可选；枚举 unhandled、handled、blocked、passed、isolated、ignored。</p>
        /// </summary>
        [JsonProperty("ActionStatus")]
        public string ActionStatus{ get; set; }

        /// <summary>
        /// <p>攻击链阶段过滤。可选；枚举 recon、brute_force、delivery、exploit、c2、lateral_movement、exfiltration。</p>
        /// </summary>
        [JsonProperty("KillChain")]
        public string KillChain{ get; set; }

        /// <summary>
        /// <p>攻击结果过滤。可选；枚举 attempt、success、fail、unknown。</p>
        /// </summary>
        [JsonProperty("AttackResult")]
        public string AttackResult{ get; set; }

        /// <summary>
        /// <p>IPS 策略动作过滤。可选；枚举 observe、block。</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// <p>攻击事件名称关键字过滤。可选，例如 SQL注入、暴力破解、恶意域名访问。</p>
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// <p>精确告警事件 ID 过滤。用于指定事件的写操作前检查和写操作后核验；事件重新聚合时返回原请求 ID 和当前事件 ID。无匹配返回空结果，多匹配或定位过程异常时失败，不退化为宽查询。</p>
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// <p>源 IP 过滤。可选。</p>
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// <p>目的 IP 过滤。可选。</p>
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// <p>云资源实例 ID 过滤。可选，例如 ins-xxxxxxxx。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>单页返回告警数。可选，默认 10，最大 50。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页偏移。可选，默认 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>排序字段。可选，默认 EndTime；枚举 EndTime、StartTime、Count。排序字段。可选，默认 EndTime；枚举 EndTime、StartTime、Count；Count 表示按单个聚合告警事件的告警发生次数/命中次数排序，对应返回中的 occurrence_count</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>排序方向。可选，默认 desc；枚举 desc、asc。</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "ActionStatus", this.ActionStatus);
            this.SetParamSimple(map, prefix + "KillChain", this.KillChain);
            this.SetParamSimple(map, prefix + "AttackResult", this.AttackResult);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

