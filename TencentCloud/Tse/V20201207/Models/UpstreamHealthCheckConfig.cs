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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamHealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// 开启主动健康检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableActiveHealthCheck")]
        public bool? EnableActiveHealthCheck{ get; set; }

        /// <summary>
        /// 主动健康检查配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActiveHealthCheck")]
        public KongActiveHealthCheck ActiveHealthCheck{ get; set; }

        /// <summary>
        /// 开启被动健康检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnablePassiveHealthCheck")]
        public bool? EnablePassiveHealthCheck{ get; set; }

        /// <summary>
        /// 被动健康检查配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassiveHealthCheck")]
        public KongPassiveHealthCheck PassiveHealthCheck{ get; set; }

        /// <summary>
        /// 连续健康阈值，单位：次
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Successes")]
        public ulong? Successes{ get; set; }

        /// <summary>
        /// 连续异常阈值，单位：次	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Failures")]
        public ulong? Failures{ get; set; }

        /// <summary>
        /// 超时阈值，单位：次
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeouts")]
        public ulong? Timeouts{ get; set; }

        /// <summary>
        /// 健康HTTP状态码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthyHttpStatuses")]
        public ulong?[] HealthyHttpStatuses{ get; set; }

        /// <summary>
        /// 异常HTTP状态码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnhealthyHttpStatuses")]
        public ulong?[] UnhealthyHttpStatuses{ get; set; }

        /// <summary>
        /// 健康检查监控上报的数据屏蔽权重为0的节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreZeroWeightNodes")]
        [System.Obsolete]
        public bool? IgnoreZeroWeightNodes{ get; set; }

        /// <summary>
        /// 健康检查支持权重为0节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZeroWeightHeathCheck")]
        public bool? ZeroWeightHeathCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableActiveHealthCheck", this.EnableActiveHealthCheck);
            this.SetParamObj(map, prefix + "ActiveHealthCheck.", this.ActiveHealthCheck);
            this.SetParamSimple(map, prefix + "EnablePassiveHealthCheck", this.EnablePassiveHealthCheck);
            this.SetParamObj(map, prefix + "PassiveHealthCheck.", this.PassiveHealthCheck);
            this.SetParamSimple(map, prefix + "Successes", this.Successes);
            this.SetParamSimple(map, prefix + "Failures", this.Failures);
            this.SetParamSimple(map, prefix + "Timeouts", this.Timeouts);
            this.SetParamArraySimple(map, prefix + "HealthyHttpStatuses.", this.HealthyHttpStatuses);
            this.SetParamArraySimple(map, prefix + "UnhealthyHttpStatuses.", this.UnhealthyHttpStatuses);
            this.SetParamSimple(map, prefix + "IgnoreZeroWeightNodes", this.IgnoreZeroWeightNodes);
            this.SetParamSimple(map, prefix + "ZeroWeightHeathCheck", this.ZeroWeightHeathCheck);
        }
    }
}

