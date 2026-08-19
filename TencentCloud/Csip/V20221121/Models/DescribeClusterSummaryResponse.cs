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

    public class DescribeClusterSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>集群总数</p>
        /// </summary>
        [JsonProperty("TotalClusterCount")]
        public ulong? TotalClusterCount{ get; set; }

        /// <summary>
        /// <p>告警集群总数</p>
        /// </summary>
        [JsonProperty("AlarmClusterCount")]
        [System.Obsolete]
        public ulong? AlarmClusterCount{ get; set; }

        /// <summary>
        /// <p>风险集群总数</p>
        /// </summary>
        [JsonProperty("RiskClusterCount")]
        [System.Obsolete]
        public ulong? RiskClusterCount{ get; set; }

        /// <summary>
        /// <p>节点总数</p>
        /// </summary>
        [JsonProperty("TotalNodeCount")]
        public ulong? TotalNodeCount{ get; set; }

        /// <summary>
        /// <p>总核数</p>
        /// </summary>
        [JsonProperty("TotalCoreCount")]
        public ulong? TotalCoreCount{ get; set; }

        /// <summary>
        /// <p>告警事件总数</p>
        /// </summary>
        [JsonProperty("AlarmEventCount")]
        [System.Obsolete]
        public ulong? AlarmEventCount{ get; set; }

        /// <summary>
        /// <p>严重告警事件数</p>
        /// </summary>
        [JsonProperty("CriticalAlarmEventCount")]
        [System.Obsolete]
        public ulong? CriticalAlarmEventCount{ get; set; }

        /// <summary>
        /// <p>高危告警事件数</p>
        /// </summary>
        [JsonProperty("HighAlarmEventCount")]
        [System.Obsolete]
        public ulong? HighAlarmEventCount{ get; set; }

        /// <summary>
        /// <p>中危告警事件数</p>
        /// </summary>
        [JsonProperty("MiddleAlarmEventCount")]
        [System.Obsolete]
        public ulong? MiddleAlarmEventCount{ get; set; }

        /// <summary>
        /// <p>低危告警事件数</p>
        /// </summary>
        [JsonProperty("LowAlarmEventCount")]
        [System.Obsolete]
        public ulong? LowAlarmEventCount{ get; set; }

        /// <summary>
        /// <p>风险事件总数</p>
        /// </summary>
        [JsonProperty("RiskEventCount")]
        [System.Obsolete]
        public ulong? RiskEventCount{ get; set; }

        /// <summary>
        /// <p>严重风险事件数</p>
        /// </summary>
        [JsonProperty("CriticalRiskEventCount")]
        [System.Obsolete]
        public ulong? CriticalRiskEventCount{ get; set; }

        /// <summary>
        /// <p>高危风险事件数</p>
        /// </summary>
        [JsonProperty("HighRiskEventCount")]
        [System.Obsolete]
        public ulong? HighRiskEventCount{ get; set; }

        /// <summary>
        /// <p>中危风险事件个数</p>
        /// </summary>
        [JsonProperty("MiddleRiskEventCount")]
        [System.Obsolete]
        public ulong? MiddleRiskEventCount{ get; set; }

        /// <summary>
        /// <p>低危风险事件个数</p>
        /// </summary>
        [JsonProperty("LowRiskEventCount")]
        [System.Obsolete]
        public ulong? LowRiskEventCount{ get; set; }

        /// <summary>
        /// <p>已使用核数额度</p>
        /// </summary>
        [JsonProperty("UsedCoreQuota")]
        public ulong? UsedCoreQuota{ get; set; }

        /// <summary>
        /// <p>已购买核数额度</p>
        /// </summary>
        [JsonProperty("PurchasedCoreQuota")]
        public ulong? PurchasedCoreQuota{ get; set; }

        /// <summary>
        /// <p>弹性计费核数</p>
        /// </summary>
        [JsonProperty("ElasticCoreQuota")]
        public ulong? ElasticCoreQuota{ get; set; }

        /// <summary>
        /// <p>集群未防护核数</p>
        /// </summary>
        [JsonProperty("UnprotectedCoreCount")]
        public ulong? UnprotectedCoreCount{ get; set; }

        /// <summary>
        /// <p>集群已防护核数</p>
        /// </summary>
        [JsonProperty("ProtectedCoreCount")]
        public ulong? ProtectedCoreCount{ get; set; }

        /// <summary>
        /// <p>未防护集群数</p>
        /// </summary>
        [JsonProperty("UnprotectedClusterCount")]
        public ulong? UnprotectedClusterCount{ get; set; }

        /// <summary>
        /// <p>已防护集群数</p>
        /// </summary>
        [JsonProperty("ProtectedClusterCount")]
        public ulong? ProtectedClusterCount{ get; set; }

        /// <summary>
        /// <p>腾讯云TKE集群数量</p>
        /// </summary>
        [JsonProperty("TkeClusterCount")]
        public ulong? TkeClusterCount{ get; set; }

        /// <summary>
        /// <p>自建集群数量</p>
        /// </summary>
        [JsonProperty("SelfBuiltClusterCount")]
        public ulong? SelfBuiltClusterCount{ get; set; }

        /// <summary>
        /// <p>严重告警集群数量</p>
        /// </summary>
        [JsonProperty("CriticalAlarmClusterCount")]
        [System.Obsolete]
        public ulong? CriticalAlarmClusterCount{ get; set; }

        /// <summary>
        /// <p>高危告警集群数量</p>
        /// </summary>
        [JsonProperty("HighAlarmClusterCount")]
        [System.Obsolete]
        public ulong? HighAlarmClusterCount{ get; set; }

        /// <summary>
        /// <p>严重风险集群数</p>
        /// </summary>
        [JsonProperty("CriticalRiskClusterCount")]
        [System.Obsolete]
        public ulong? CriticalRiskClusterCount{ get; set; }

        /// <summary>
        /// <p>高危风险集群数量</p>
        /// </summary>
        [JsonProperty("HighRiskClusterCount")]
        [System.Obsolete]
        public ulong? HighRiskClusterCount{ get; set; }

        /// <summary>
        /// <p>未绑定旗舰版节点数量</p>
        /// </summary>
        [JsonProperty("UnboundUltimateNodeCount")]
        public ulong? UnboundUltimateNodeCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalClusterCount", this.TotalClusterCount);
            this.SetParamSimple(map, prefix + "AlarmClusterCount", this.AlarmClusterCount);
            this.SetParamSimple(map, prefix + "RiskClusterCount", this.RiskClusterCount);
            this.SetParamSimple(map, prefix + "TotalNodeCount", this.TotalNodeCount);
            this.SetParamSimple(map, prefix + "TotalCoreCount", this.TotalCoreCount);
            this.SetParamSimple(map, prefix + "AlarmEventCount", this.AlarmEventCount);
            this.SetParamSimple(map, prefix + "CriticalAlarmEventCount", this.CriticalAlarmEventCount);
            this.SetParamSimple(map, prefix + "HighAlarmEventCount", this.HighAlarmEventCount);
            this.SetParamSimple(map, prefix + "MiddleAlarmEventCount", this.MiddleAlarmEventCount);
            this.SetParamSimple(map, prefix + "LowAlarmEventCount", this.LowAlarmEventCount);
            this.SetParamSimple(map, prefix + "RiskEventCount", this.RiskEventCount);
            this.SetParamSimple(map, prefix + "CriticalRiskEventCount", this.CriticalRiskEventCount);
            this.SetParamSimple(map, prefix + "HighRiskEventCount", this.HighRiskEventCount);
            this.SetParamSimple(map, prefix + "MiddleRiskEventCount", this.MiddleRiskEventCount);
            this.SetParamSimple(map, prefix + "LowRiskEventCount", this.LowRiskEventCount);
            this.SetParamSimple(map, prefix + "UsedCoreQuota", this.UsedCoreQuota);
            this.SetParamSimple(map, prefix + "PurchasedCoreQuota", this.PurchasedCoreQuota);
            this.SetParamSimple(map, prefix + "ElasticCoreQuota", this.ElasticCoreQuota);
            this.SetParamSimple(map, prefix + "UnprotectedCoreCount", this.UnprotectedCoreCount);
            this.SetParamSimple(map, prefix + "ProtectedCoreCount", this.ProtectedCoreCount);
            this.SetParamSimple(map, prefix + "UnprotectedClusterCount", this.UnprotectedClusterCount);
            this.SetParamSimple(map, prefix + "ProtectedClusterCount", this.ProtectedClusterCount);
            this.SetParamSimple(map, prefix + "TkeClusterCount", this.TkeClusterCount);
            this.SetParamSimple(map, prefix + "SelfBuiltClusterCount", this.SelfBuiltClusterCount);
            this.SetParamSimple(map, prefix + "CriticalAlarmClusterCount", this.CriticalAlarmClusterCount);
            this.SetParamSimple(map, prefix + "HighAlarmClusterCount", this.HighAlarmClusterCount);
            this.SetParamSimple(map, prefix + "CriticalRiskClusterCount", this.CriticalRiskClusterCount);
            this.SetParamSimple(map, prefix + "HighRiskClusterCount", this.HighRiskClusterCount);
            this.SetParamSimple(map, prefix + "UnboundUltimateNodeCount", this.UnboundUltimateNodeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

