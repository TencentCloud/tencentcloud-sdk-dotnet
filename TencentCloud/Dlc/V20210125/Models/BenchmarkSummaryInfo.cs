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

    public class BenchmarkSummaryInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型提供方</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>模型类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>参数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParameterSize")]
        public string ParameterSize{ get; set; }

        /// <summary>
        /// <p>评测所用的服务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>评测任务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>该模型的评测任务总数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BenchmarkCount")]
        public ulong? BenchmarkCount{ get; set; }

        /// <summary>
        /// <p>输入 Token 数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputTokens")]
        public ulong? InputTokens{ get; set; }

        /// <summary>
        /// <p>输出 Token 数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputTokens")]
        public ulong? OutputTokens{ get; set; }

        /// <summary>
        /// <p>每秒请求数 (QPS)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestsPerSecond")]
        public float? RequestsPerSecond{ get; set; }

        /// <summary>
        /// <p>最大并发数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public ulong? MaxConcurrency{ get; set; }

        /// <summary>
        /// <p>TTFT 平均值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeToFirstTokenAvg")]
        public float? TimeToFirstTokenAvg{ get; set; }

        /// <summary>
        /// <p>TTFT 中间值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeToFirstTokenMedian")]
        public float? TimeToFirstTokenMedian{ get; set; }

        /// <summary>
        /// <p>TTFT P99 值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeToFirstTokenP99")]
        public float? TimeToFirstTokenP99{ get; set; }

        /// <summary>
        /// <p>TPOT 平均值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimePerOutputTokenAvg")]
        public float? TimePerOutputTokenAvg{ get; set; }

        /// <summary>
        /// <p>TPOT 中间值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimePerOutputTokenMedian")]
        public float? TimePerOutputTokenMedian{ get; set; }

        /// <summary>
        /// <p>TPOT P99 值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimePerOutputTokenP99")]
        public float? TimePerOutputTokenP99{ get; set; }

        /// <summary>
        /// <p>ITL 平均值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InterTokenLatencyAvg")]
        public float? InterTokenLatencyAvg{ get; set; }

        /// <summary>
        /// <p>ITL 中间值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InterTokenLatencyMedian")]
        public float? InterTokenLatencyMedian{ get; set; }

        /// <summary>
        /// <p>ITL P99 值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InterTokenLatencyP99")]
        public float? InterTokenLatencyP99{ get; set; }

        /// <summary>
        /// <p>E2E 平均值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndToEndAvg")]
        public float? EndToEndAvg{ get; set; }

        /// <summary>
        /// <p>E2E 中间值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndToEndMedian")]
        public float? EndToEndMedian{ get; set; }

        /// <summary>
        /// <p>E2E P99 值(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndToEndP99")]
        public float? EndToEndP99{ get; set; }

        /// <summary>
        /// <p>评测完成时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "ParameterSize", this.ParameterSize);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "BenchmarkCount", this.BenchmarkCount);
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "RequestsPerSecond", this.RequestsPerSecond);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TimeToFirstTokenAvg", this.TimeToFirstTokenAvg);
            this.SetParamSimple(map, prefix + "TimeToFirstTokenMedian", this.TimeToFirstTokenMedian);
            this.SetParamSimple(map, prefix + "TimeToFirstTokenP99", this.TimeToFirstTokenP99);
            this.SetParamSimple(map, prefix + "TimePerOutputTokenAvg", this.TimePerOutputTokenAvg);
            this.SetParamSimple(map, prefix + "TimePerOutputTokenMedian", this.TimePerOutputTokenMedian);
            this.SetParamSimple(map, prefix + "TimePerOutputTokenP99", this.TimePerOutputTokenP99);
            this.SetParamSimple(map, prefix + "InterTokenLatencyAvg", this.InterTokenLatencyAvg);
            this.SetParamSimple(map, prefix + "InterTokenLatencyMedian", this.InterTokenLatencyMedian);
            this.SetParamSimple(map, prefix + "InterTokenLatencyP99", this.InterTokenLatencyP99);
            this.SetParamSimple(map, prefix + "EndToEndAvg", this.EndToEndAvg);
            this.SetParamSimple(map, prefix + "EndToEndMedian", this.EndToEndMedian);
            this.SetParamSimple(map, prefix + "EndToEndP99", this.EndToEndP99);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

