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

    public class BenchmarkTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>benchmark任务id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>关联的推理服务ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>关联的推理服务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>任务状态（Running/Completed/Failed/Pending/Stopped）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

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
        /// <p>Prompts 总数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalPrompts")]
        public ulong? TotalPrompts{ get; set; }

        /// <summary>
        /// <p>是否经 Ingress 网关（true=网关, false=集群内直连 SVC）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseGateway")]
        public bool? UseGateway{ get; set; }

        /// <summary>
        /// <p>直连模式下使用的部署名称（仅 UseGateway=false 时有值）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeploymentName")]
        public string DeploymentName{ get; set; }

        /// <summary>
        /// <p>API Key ID（走网关时使用的 API Key 标识）</p>
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// <p>API Key 名称</p>
        /// </summary>
        [JsonProperty("ApiKeyName")]
        public string ApiKeyName{ get; set; }

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
        /// <p>Token 吞吐量 (output tokens/s)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenThroughput")]
        public float? TokenThroughput{ get; set; }

        /// <summary>
        /// <p>请求吞吐量 (requests/s)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestThroughput")]
        public float? RequestThroughput{ get; set; }

        /// <summary>
        /// <p>错误信息（失败时）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>appid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>创建时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>主账号uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>子账号uin</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "RequestsPerSecond", this.RequestsPerSecond);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TotalPrompts", this.TotalPrompts);
            this.SetParamSimple(map, prefix + "UseGateway", this.UseGateway);
            this.SetParamSimple(map, prefix + "DeploymentName", this.DeploymentName);
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "ApiKeyName", this.ApiKeyName);
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
            this.SetParamSimple(map, prefix + "TokenThroughput", this.TokenThroughput);
            this.SetParamSimple(map, prefix + "RequestThroughput", this.RequestThroughput);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
        }
    }
}

