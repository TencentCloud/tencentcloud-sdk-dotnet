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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulScanTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务详情列表</p>
        /// </summary>
        [JsonProperty("List")]
        public VulScanTaskDetail[] List{ get; set; }

        /// <summary>
        /// <p>总数</p>
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// <p>漏洞数量</p>
        /// </summary>
        [JsonProperty("Vuls")]
        public ulong? Vuls{ get; set; }

        /// <summary>
        /// <p>扫描数量</p>
        /// </summary>
        [JsonProperty("Scanned")]
        public ulong? Scanned{ get; set; }

        /// <summary>
        /// <p>风险数量</p>
        /// </summary>
        [JsonProperty("Risk")]
        public ulong? Risk{ get; set; }

        /// <summary>
        /// <p>失败数量</p>
        /// </summary>
        [JsonProperty("Failed")]
        public ulong? Failed{ get; set; }

        /// <summary>
        /// <p>扫描进度（0-100）</p>
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// <p>任务pdf报告地址</p>
        /// </summary>
        [JsonProperty("TaskPdf")]
        public string TaskPdf{ get; set; }

        /// <summary>
        /// <p>任务excel报告地址</p>
        /// </summary>
        [JsonProperty("TaskExcel")]
        public string TaskExcel{ get; set; }

        /// <summary>
        /// <p>任务开始时间，格式：2006-01-02T15:04:05+08:00</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>任务结束时间，格式：2006-01-02T15:04:05+08:00</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>漏洞ID</p>
        /// </summary>
        [JsonProperty("VulId")]
        public ulong?[] VulId{ get; set; }

        /// <summary>
        /// <p>KB编号</p>
        /// </summary>
        [JsonProperty("KbNo")]
        public string[] KbNo{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Vuls", this.Vuls);
            this.SetParamSimple(map, prefix + "Scanned", this.Scanned);
            this.SetParamSimple(map, prefix + "Risk", this.Risk);
            this.SetParamSimple(map, prefix + "Failed", this.Failed);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TaskPdf", this.TaskPdf);
            this.SetParamSimple(map, prefix + "TaskExcel", this.TaskExcel);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "VulId.", this.VulId);
            this.SetParamArraySimple(map, prefix + "KbNo.", this.KbNo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

