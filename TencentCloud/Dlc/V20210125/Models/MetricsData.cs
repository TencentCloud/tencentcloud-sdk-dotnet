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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricsData : AbstractModel
    {
        
        /// <summary>
        /// <p>每秒请求数（QPS）</p>
        /// </summary>
        [JsonProperty("RequestsPerSecond")]
        public float? RequestsPerSecond{ get; set; }

        /// <summary>
        /// <p>错误率（0~1）</p>
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }

        /// <summary>
        /// <p>P95 延迟（毫秒）</p>
        /// </summary>
        [JsonProperty("P95LatencyMs")]
        public float? P95LatencyMs{ get; set; }

        /// <summary>
        /// <p>P99 延迟（毫秒）</p>
        /// </summary>
        [JsonProperty("P99LatencyMs")]
        public float? P99LatencyMs{ get; set; }

        /// <summary>
        /// <p>队列深度（排队中的请求数）</p>
        /// </summary>
        [JsonProperty("QueueDepth")]
        public float? QueueDepth{ get; set; }

        /// <summary>
        /// <p>TTFT P99 延迟（毫秒，仅 vLLM）</p>
        /// </summary>
        [JsonProperty("TimeToFirstTokenP99Ms")]
        public float? TimeToFirstTokenP99Ms{ get; set; }

        /// <summary>
        /// <p>TPOT P99 延迟（毫秒，仅 vLLM）</p>
        /// </summary>
        [JsonProperty("TimePerOutputTokenP99Ms")]
        public float? TimePerOutputTokenP99Ms{ get; set; }

        /// <summary>
        /// <p>Token 吞吐量（tokens/s，仅 vLLM）</p>
        /// </summary>
        [JsonProperty("TokenThroughput")]
        public float? TokenThroughput{ get; set; }

        /// <summary>
        /// <p>GPU 利用率（0~100，百分比）</p>
        /// </summary>
        [JsonProperty("GpuUtilization")]
        public float? GpuUtilization{ get; set; }

        /// <summary>
        /// <p>GPU 显存已用（MB）</p>
        /// </summary>
        [JsonProperty("GpuMemoryUsedMB")]
        public float? GpuMemoryUsedMB{ get; set; }

        /// <summary>
        /// <p>GPU 显存总量（MB）</p>
        /// </summary>
        [JsonProperty("GpuMemoryTotalMB")]
        public float? GpuMemoryTotalMB{ get; set; }

        /// <summary>
        /// <p>CPU 利用率（0~100，百分比）</p>
        /// </summary>
        [JsonProperty("CpuUtilization")]
        public float? CpuUtilization{ get; set; }

        /// <summary>
        /// <p>内存已用（字节）</p>
        /// </summary>
        [JsonProperty("MemoryUsedBytes")]
        public float? MemoryUsedBytes{ get; set; }

        /// <summary>
        /// <p>内存总量（字节）</p>
        /// </summary>
        [JsonProperty("MemoryTotalBytes")]
        public float? MemoryTotalBytes{ get; set; }

        /// <summary>
        /// <p>网络接收速度（MB/s）</p>
        /// </summary>
        [JsonProperty("NetworkReceiveMBPerSecond")]
        public float? NetworkReceiveMBPerSecond{ get; set; }

        /// <summary>
        /// <p>网络发送速度（MB/s）</p>
        /// </summary>
        [JsonProperty("NetworkSendMBPerSecond")]
        public float? NetworkSendMBPerSecond{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestsPerSecond", this.RequestsPerSecond);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
            this.SetParamSimple(map, prefix + "P95LatencyMs", this.P95LatencyMs);
            this.SetParamSimple(map, prefix + "P99LatencyMs", this.P99LatencyMs);
            this.SetParamSimple(map, prefix + "QueueDepth", this.QueueDepth);
            this.SetParamSimple(map, prefix + "TimeToFirstTokenP99Ms", this.TimeToFirstTokenP99Ms);
            this.SetParamSimple(map, prefix + "TimePerOutputTokenP99Ms", this.TimePerOutputTokenP99Ms);
            this.SetParamSimple(map, prefix + "TokenThroughput", this.TokenThroughput);
            this.SetParamSimple(map, prefix + "GpuUtilization", this.GpuUtilization);
            this.SetParamSimple(map, prefix + "GpuMemoryUsedMB", this.GpuMemoryUsedMB);
            this.SetParamSimple(map, prefix + "GpuMemoryTotalMB", this.GpuMemoryTotalMB);
            this.SetParamSimple(map, prefix + "CpuUtilization", this.CpuUtilization);
            this.SetParamSimple(map, prefix + "MemoryUsedBytes", this.MemoryUsedBytes);
            this.SetParamSimple(map, prefix + "MemoryTotalBytes", this.MemoryTotalBytes);
            this.SetParamSimple(map, prefix + "NetworkReceiveMBPerSecond", this.NetworkReceiveMBPerSecond);
            this.SetParamSimple(map, prefix + "NetworkSendMBPerSecond", this.NetworkSendMBPerSecond);
        }
    }
}

