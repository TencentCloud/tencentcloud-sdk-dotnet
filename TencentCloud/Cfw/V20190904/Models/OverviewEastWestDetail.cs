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

    public class OverviewEastWestDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>东西向总带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("TotalMbps")]
        public long? TotalMbps{ get; set; }

        /// <summary>
        /// <p>当前已使用流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("UsedBps")]
        public long? UsedBps{ get; set; }

        /// <summary>
        /// <p>当前带宽使用率。</p><p>单位：%</p>
        /// </summary>
        [JsonProperty("UsagePercent")]
        public float? UsagePercent{ get; set; }

        /// <summary>
        /// <p>已分配并使用的带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("AllocatedBandwidthUsedMbps")]
        public long? AllocatedBandwidthUsedMbps{ get; set; }

        /// <summary>
        /// <p>当前仍可使用带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("CanUsedBandwidthMbps")]
        public long? CanUsedBandwidthMbps{ get; set; }

        /// <summary>
        /// <p>集群模式带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("ClusterModeWidthMbps")]
        public long? ClusterModeWidthMbps{ get; set; }

        /// <summary>
        /// <p>主备模式带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("MasterSlaveModeWidthMbps")]
        public long? MasterSlaveModeWidthMbps{ get; set; }

        /// <summary>
        /// <p>同地域防火墙实例 ID。</p>
        /// </summary>
        [JsonProperty("SameRegionFwInsId")]
        public string SameRegionFwInsId{ get; set; }

        /// <summary>
        /// <p>同地域防火墙实例名称。</p>
        /// </summary>
        [JsonProperty("SameRegionFwInsName")]
        public string SameRegionFwInsName{ get; set; }

        /// <summary>
        /// <p>同地域防火墙实例峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("SameRegionMaxFlowBps")]
        public long? SameRegionMaxFlowBps{ get; set; }

        /// <summary>
        /// <p>跨地域防火墙实例 ID。</p>
        /// </summary>
        [JsonProperty("DiffRegionFwInsId")]
        public string DiffRegionFwInsId{ get; set; }

        /// <summary>
        /// <p>跨地域防火墙实例名称。</p>
        /// </summary>
        [JsonProperty("DiffRegionFwInsName")]
        public string DiffRegionFwInsName{ get; set; }

        /// <summary>
        /// <p>跨地域防火墙实例峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("DiffRegionMaxFlowBps")]
        public long? DiffRegionMaxFlowBps{ get; set; }

        /// <summary>
        /// <p>防火墙实例组 ID。</p>
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// <p>防火墙实例组名称。</p>
        /// </summary>
        [JsonProperty("FwGroupName")]
        public string FwGroupName{ get; set; }

        /// <summary>
        /// <p>防火墙实例组峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("FwGroupMaxFlowBps")]
        public long? FwGroupMaxFlowBps{ get; set; }

        /// <summary>
        /// <p>防火墙实例 ID。</p>
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }

        /// <summary>
        /// <p>防火墙实例名称。</p>
        /// </summary>
        [JsonProperty("FwInsName")]
        public string FwInsName{ get; set; }

        /// <summary>
        /// <p>防火墙实例峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("FwInsMaxFlowBps")]
        public long? FwInsMaxFlowBps{ get; set; }

        /// <summary>
        /// <p>集群 VPC 峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("ClusterVpcMaxFlowBps")]
        public long? ClusterVpcMaxFlowBps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalMbps", this.TotalMbps);
            this.SetParamSimple(map, prefix + "UsedBps", this.UsedBps);
            this.SetParamSimple(map, prefix + "UsagePercent", this.UsagePercent);
            this.SetParamSimple(map, prefix + "AllocatedBandwidthUsedMbps", this.AllocatedBandwidthUsedMbps);
            this.SetParamSimple(map, prefix + "CanUsedBandwidthMbps", this.CanUsedBandwidthMbps);
            this.SetParamSimple(map, prefix + "ClusterModeWidthMbps", this.ClusterModeWidthMbps);
            this.SetParamSimple(map, prefix + "MasterSlaveModeWidthMbps", this.MasterSlaveModeWidthMbps);
            this.SetParamSimple(map, prefix + "SameRegionFwInsId", this.SameRegionFwInsId);
            this.SetParamSimple(map, prefix + "SameRegionFwInsName", this.SameRegionFwInsName);
            this.SetParamSimple(map, prefix + "SameRegionMaxFlowBps", this.SameRegionMaxFlowBps);
            this.SetParamSimple(map, prefix + "DiffRegionFwInsId", this.DiffRegionFwInsId);
            this.SetParamSimple(map, prefix + "DiffRegionFwInsName", this.DiffRegionFwInsName);
            this.SetParamSimple(map, prefix + "DiffRegionMaxFlowBps", this.DiffRegionMaxFlowBps);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "FwGroupName", this.FwGroupName);
            this.SetParamSimple(map, prefix + "FwGroupMaxFlowBps", this.FwGroupMaxFlowBps);
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
            this.SetParamSimple(map, prefix + "FwInsName", this.FwInsName);
            this.SetParamSimple(map, prefix + "FwInsMaxFlowBps", this.FwInsMaxFlowBps);
            this.SetParamSimple(map, prefix + "ClusterVpcMaxFlowBps", this.ClusterVpcMaxFlowBps);
        }
    }
}

