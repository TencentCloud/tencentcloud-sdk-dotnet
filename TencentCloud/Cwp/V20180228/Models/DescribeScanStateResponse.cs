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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanStateResponse : AbstractModel
    {
        
        /// <summary>
        /// 0 从未扫描过、 1 扫描中、 2扫描完成、 3停止中、 4停止完成
        /// </summary>
        [JsonProperty("ScanState")]
        public ulong? ScanState{ get; set; }

        /// <summary>
        /// 扫描进度
        /// </summary>
        [JsonProperty("Schedule")]
        public ulong? Schedule{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 任务扫描的漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong?[] VulId{ get; set; }

        /// <summary>
        /// 0一键检测 1定时检测
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 开始扫描时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanBeginTime")]
        public string ScanBeginTime{ get; set; }

        /// <summary>
        /// 扫描漏洞数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskEventCount")]
        public ulong? RiskEventCount{ get; set; }

        /// <summary>
        /// 扫描结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanState", this.ScanState);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "VulId.", this.VulId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ScanBeginTime", this.ScanBeginTime);
            this.SetParamSimple(map, prefix + "RiskEventCount", this.RiskEventCount);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

