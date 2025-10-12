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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricData : AbstractModel
    {
        
        /// <summary>
        /// 指标名称
        /// 
        /// - ConcurrencyUsage --- 并发使用率
        /// - CpuCoreUsage --- cpu使用率
        /// - CpuLoad --- cpu负载
        /// - DevelopQueueTask --- 正在队列中的开发任务数量
        /// - DevelopRunningTask --- 正在运行的开发任务数量
        /// - DevelopSchedulingTask --- 正在调度的开发任务数量
        /// - DiskUsage --- 磁盘使用情况
        /// - DiskUsed --- 磁盘已用量
        /// - MaximumConcurrency --- 最大并发
        /// - MemoryLoad --- 内存负载
        /// - MemoryUsage --- 内存使用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 当前值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotValue")]
        public ulong? SnapshotValue{ get; set; }

        /// <summary>
        /// 指标趋势
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrendList")]
        public TrendData[] TrendList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "SnapshotValue", this.SnapshotValue);
            this.SetParamArrayObj(map, prefix + "TrendList.", this.TrendList);
        }
    }
}

