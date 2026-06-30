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

    public class SpecInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>实例规格ID，利用DescribeZones返回的SpecId，结合DescribeProductConfig返回的可售卖规格信息，可获悉某个可用区下可购买什么规格的实例</p>
        /// </summary>
        [JsonProperty("SpecId")]
        public long? SpecId{ get; set; }

        /// <summary>
        /// <p>机型ID</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>机型中文名称</p>
        /// </summary>
        [JsonProperty("MachineTypeName")]
        public string MachineTypeName{ get; set; }

        /// <summary>
        /// <p>数据库版本信息。取值为2008R2（表示SQL Server 2008 R2），2012SP3（表示SQL Server 2012），2016SP1（表示SQL Server 2016 SP1）</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>Version字段对应的版本名称</p>
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// <p>内存大小，单位GB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>CPU核数</p>
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// <p>此规格下最小的磁盘大小，单位GB</p>
        /// </summary>
        [JsonProperty("MinStorage")]
        public long? MinStorage{ get; set; }

        /// <summary>
        /// <p>此规格下最大的磁盘大小，单位GB</p>
        /// </summary>
        [JsonProperty("MaxStorage")]
        public long? MaxStorage{ get; set; }

        /// <summary>
        /// <p>此规格对应的QPS大小</p>
        /// </summary>
        [JsonProperty("QPS")]
        public long? QPS{ get; set; }

        /// <summary>
        /// <p>此规格的中文描述信息</p>
        /// </summary>
        [JsonProperty("SuitInfo")]
        public string SuitInfo{ get; set; }

        /// <summary>
        /// <p>此规格对应的包年包月Pid</p>
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// <p>此规格对应的按量计费Pid列表</p>
        /// </summary>
        [JsonProperty("PostPid")]
        public long?[] PostPid{ get; set; }

        /// <summary>
        /// <p>此规格下支持的付费模式，POST-仅支持按量计费 PRE-仅支持包年包月 ALL-支持所有</p>
        /// </summary>
        [JsonProperty("PayModeStatus")]
        public string PayModeStatus{ get; set; }

        /// <summary>
        /// <p>购买实例的类型 HA-本地盘高可用(包括双机高可用，alwaysOn集群)，RO-本地盘只读副本，SI-云盘版单节点,BI-商业智能服务，cvmHA-云盘版高可用，cvmRO-云盘版只读副本，MultiHA-多节点，cvmMultiHA-云盘多节点<br>示例值：HA</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>跨可用区类型，MultiZones-只支持跨可用区，SameZones-只支持同可用区，ALL-支持所有</p>
        /// </summary>
        [JsonProperty("MultiZonesStatus")]
        public string MultiZonesStatus{ get; set; }

        /// <summary>
        /// <p>最小磁盘容量时的基准</p><p>单位：IOPS</p>
        /// </summary>
        [JsonProperty("MinBaselineIOPS")]
        public ulong? MinBaselineIOPS{ get; set; }

        /// <summary>
        /// <p>最大磁盘容量时的基准</p><p>单位：IOPS</p>
        /// </summary>
        [JsonProperty("MaxBaselineIOPS")]
        public ulong? MaxBaselineIOPS{ get; set; }

        /// <summary>
        /// <p>最小磁盘容量时的基准吞吐量</p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("MinBaselineThroughput")]
        public ulong? MinBaselineThroughput{ get; set; }

        /// <summary>
        /// <p>最大磁盘容量时的基准吞吐量</p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("MaxBaselineThroughput")]
        public ulong? MaxBaselineThroughput{ get; set; }

        /// <summary>
        /// <p>是否支持额外 IO 性能</p><p>枚举值：</p><ul><li>TRUE： 支持额外 IO 性能</li><li>FALSE： 不支持额外 IO 性能</li></ul>
        /// </summary>
        [JsonProperty("ExtraIOSupported")]
        public bool? ExtraIOSupported{ get; set; }

        /// <summary>
        /// <p>额外 IO 最大吞吐量</p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("MaxExtraThroughput")]
        public ulong? MaxExtraThroughput{ get; set; }

        /// <summary>
        /// <p>支持额外 IO 的最小磁盘容量</p><p>单位： GB</p><p>默认值：460</p>
        /// </summary>
        [JsonProperty("MinDiskSizeForExtraIO")]
        public ulong? MinDiskSizeForExtraIO{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineTypeName", this.MachineTypeName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "MinStorage", this.MinStorage);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "QPS", this.QPS);
            this.SetParamSimple(map, prefix + "SuitInfo", this.SuitInfo);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamArraySimple(map, prefix + "PostPid.", this.PostPid);
            this.SetParamSimple(map, prefix + "PayModeStatus", this.PayModeStatus);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MultiZonesStatus", this.MultiZonesStatus);
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

