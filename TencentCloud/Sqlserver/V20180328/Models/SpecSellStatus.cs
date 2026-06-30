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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpecSellStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>可售卖的规格唯一ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>实例规格ID</p>
        /// </summary>
        [JsonProperty("SpecId")]
        public ulong? SpecId{ get; set; }

        /// <summary>
        /// <p>此规格下支持的付费模式，POST-仅支持按量计费 PRE-仅支持包年包月 ALL-支持所有</p>
        /// </summary>
        [JsonProperty("PayModeStatus")]
        public string PayModeStatus{ get; set; }

        /// <summary>
        /// <p>产品类型，购买实例的类型 HA-本地盘高可用(包括双机高可用，alwaysOn集群)，RO-本地盘只读副本，SI-云盘版单节点,BI-商业智能服务，cvmHA-云盘版高可用，cvmRO-云盘版只读副本，MultiHA-多节点，cvmMultiHA-云盘多节点</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>该规格支持的是否跨可用去，MultiZones-只支持跨可用区，SameZones-只支持同可用区，ALL-支持所有</p>
        /// </summary>
        [JsonProperty("MultiZonesStatus")]
        public string MultiZonesStatus{ get; set; }

        /// <summary>
        /// <p>架构标识，SINGLE-单节点 DOUBLE-双节点 TRIPLE-三节点 MULTI-多节点<br>示例值：SINGLE</p>
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// <p>类型标识，EXCLUSIVE-独享型，SHARED-共享型</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// <p>数据库版本信息</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>每个可用区的售卖状态集合</p>
        /// </summary>
        [JsonProperty("ZoneStatusSet")]
        public ZoneStatus[] ZoneStatusSet{ get; set; }

        /// <summary>
        /// <p>规格的参考价格，实际价格以询价接口为准</p>
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }

        /// <summary>
        /// <p>规格售卖状态 1-正常 2-关闭售卖但是可以升级 3-完全关闭售卖</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>最小磁盘容量时的基准 </p><p>单位：IOPS</p>
        /// </summary>
        [JsonProperty("MinBaselineIOPS")]
        public ulong? MinBaselineIOPS{ get; set; }

        /// <summary>
        /// <p>最大磁盘容量时的基准 </p><p>单位：IOPS</p>
        /// </summary>
        [JsonProperty("MaxBaselineIOPS")]
        public ulong? MaxBaselineIOPS{ get; set; }

        /// <summary>
        /// <p>最小磁盘容量时的基准吞吐量 </p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("MinBaselineThroughput")]
        public ulong? MinBaselineThroughput{ get; set; }

        /// <summary>
        /// <p>最大磁盘容量时的基准吞吐量 </p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("MaxBaselineThroughput")]
        public ulong? MaxBaselineThroughput{ get; set; }

        /// <summary>
        /// <p>是否支持额外 IO 性能</p><p>枚举值：</p><ul><li>TRUE： 支持额外 IO 性能</li><li>FALSE： 不支持额外 IO 性能</li></ul>
        /// </summary>
        [JsonProperty("ExtraIOSupported")]
        public bool? ExtraIOSupported{ get; set; }

        /// <summary>
        /// <p>额外 IO 最大吞吐量 </p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("MaxExtraThroughput")]
        public ulong? MaxExtraThroughput{ get; set; }

        /// <summary>
        /// <p>支持额外 IO 的最小磁盘容量</p><p>单位：GB</p><p>默认值：460</p>
        /// </summary>
        [JsonProperty("MinDiskSizeForExtraIO")]
        public ulong? MinDiskSizeForExtraIO{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "PayModeStatus", this.PayModeStatus);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MultiZonesStatus", this.MultiZonesStatus);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "ZoneStatusSet.", this.ZoneStatusSet);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MinBaselineIOPS", this.MinBaselineIOPS);
            this.SetParamSimple(map, prefix + "MaxBaselineIOPS", this.MaxBaselineIOPS);
            this.SetParamSimple(map, prefix + "MinBaselineThroughput", this.MinBaselineThroughput);
            this.SetParamSimple(map, prefix + "MaxBaselineThroughput", this.MaxBaselineThroughput);
            this.SetParamSimple(map, prefix + "ExtraIOSupported", this.ExtraIOSupported);
            this.SetParamSimple(map, prefix + "MaxExtraThroughput", this.MaxExtraThroughput);
            this.SetParamSimple(map, prefix + "MinDiskSizeForExtraIO", this.MinDiskSizeForExtraIO);
        }
    }
}

