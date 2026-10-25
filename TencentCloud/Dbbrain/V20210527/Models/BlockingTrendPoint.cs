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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlockingTrendPoint : AbstractModel
    {
        
        /// <summary>
        /// <p>该 bucket 的实际聚合区间左端（含），格式：yyyy-MM-dd HH:mm:ss。聚合区间为前闭后开 [StartTime, EndTime)。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>该 bucket 的实际聚合区间右端（不含），格式：yyyy-MM-dd HH:mm:ss。即 StartTime + GranularityMs。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>该 bucket 内的阻塞 report 行数（底层 blocked_process_report 事件数），无数据 bucket 返回 0。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockCount")]
        public long? LockCount{ get; set; }

        /// <summary>
        /// <p>该 bucket 内观测到的不同 monitorLoop 数量（lock monitor 扫描快照数），无数据 bucket 返回 0。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorLoopCount")]
        public long? MonitorLoopCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LockCount", this.LockCount);
            this.SetParamSimple(map, prefix + "MonitorLoopCount", this.MonitorLoopCount);
        }
    }
}

