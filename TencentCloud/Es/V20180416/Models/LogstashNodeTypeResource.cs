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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogstashNodeTypeResource : AbstractModel
    {
        
        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("NodeTypeName")]
        public string NodeTypeName{ get; set; }

        /// <summary>
        /// 是否可售
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// 规格信息
        /// </summary>
        [JsonProperty("NodeTypeInfo")]
        public NodeTypeInfo NodeTypeInfo{ get; set; }

        /// <summary>
        /// SSD盘是否可售
        /// </summary>
        [JsonProperty("SsdAvailable")]
        public bool? SsdAvailable{ get; set; }

        /// <summary>
        /// SSD磁盘取值范围
        /// </summary>
        [JsonProperty("SsdDiskSizeRange")]
        public DiskSizeRange SsdDiskSizeRange{ get; set; }

        /// <summary>
        /// SATA盘是否可售
        /// </summary>
        [JsonProperty("SataAvailable")]
        public bool? SataAvailable{ get; set; }

        /// <summary>
        /// SATA磁盘取值范围
        /// </summary>
        [JsonProperty("SataDiskSizeRange")]
        public DiskSizeRange SataDiskSizeRange{ get; set; }

        /// <summary>
        /// SSD机型售罄原因
        /// </summary>
        [JsonProperty("SsdSoldOutReason")]
        public string SsdSoldOutReason{ get; set; }

        /// <summary>
        /// SATA机型售罄原因
        /// </summary>
        [JsonProperty("SataSoldOutReason")]
        public string SataSoldOutReason{ get; set; }

        /// <summary>
        /// 本地盘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDiskInfo")]
        public LocalDiskInfo LocalDiskInfo{ get; set; }

        /// <summary>
        /// 云盘块数取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskCountRange")]
        public DiskCountRange DiskCountRange{ get; set; }

        /// <summary>
        /// 增强型SSD是否可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HSsdAvailable")]
        public bool? HSsdAvailable{ get; set; }

        /// <summary>
        /// 增强型SSD机型售罄原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HSsdSoldOutReason")]
        public string HSsdSoldOutReason{ get; set; }

        /// <summary>
        /// 增强型SSD磁盘取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HSsdDiskSizeRange")]
        public DiskSizeRange HSsdDiskSizeRange{ get; set; }

        /// <summary>
        /// 吞吐型云盘是否可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThroughputAvailable")]
        public bool? ThroughputAvailable{ get; set; }

        /// <summary>
        /// 吞吐型云盘售罄原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThroughputSoldOutReason")]
        public string ThroughputSoldOutReason{ get; set; }

        /// <summary>
        /// 吞吐型云盘取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThroughputDiskSizeRange")]
        public DiskSizeRange ThroughputDiskSizeRange{ get; set; }

        /// <summary>
        /// BigData盘是否可售
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BigDataAvailable")]
        public bool? BigDataAvailable{ get; set; }

        /// <summary>
        /// BigData盘售罄原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BigDataSoldOutReason")]
        public string BigDataSoldOutReason{ get; set; }

        /// <summary>
        /// BigData磁盘取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BigDataDiskSizeRange")]
        public DiskSizeRange BigDataDiskSizeRange{ get; set; }

        /// <summary>
        /// HighIO盘是否可售
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighIOAvailable")]
        public bool? HighIOAvailable{ get; set; }

        /// <summary>
        /// HighIO盘售罄原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighIOSoldOutReason")]
        public string HighIOSoldOutReason{ get; set; }

        /// <summary>
        /// HighIO磁盘取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighIODiskSizeRange")]
        public DiskSizeRange HighIODiskSizeRange{ get; set; }

        /// <summary>
        /// Bssd盘是否可售
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdAvailable")]
        public bool? BssdAvailable{ get; set; }

        /// <summary>
        /// Bssd盘售罄原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdSoldOutReason")]
        public string BssdSoldOutReason{ get; set; }

        /// <summary>
        /// Bssd盘取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdDiskSizeRange")]
        public DiskSizeRange BssdDiskSizeRange{ get; set; }

        /// <summary>
        /// GpuInfo
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuInfo")]
        public GpuInfo GpuInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeTypeName", this.NodeTypeName);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamObj(map, prefix + "NodeTypeInfo.", this.NodeTypeInfo);
            this.SetParamSimple(map, prefix + "SsdAvailable", this.SsdAvailable);
            this.SetParamObj(map, prefix + "SsdDiskSizeRange.", this.SsdDiskSizeRange);
            this.SetParamSimple(map, prefix + "SataAvailable", this.SataAvailable);
            this.SetParamObj(map, prefix + "SataDiskSizeRange.", this.SataDiskSizeRange);
            this.SetParamSimple(map, prefix + "SsdSoldOutReason", this.SsdSoldOutReason);
            this.SetParamSimple(map, prefix + "SataSoldOutReason", this.SataSoldOutReason);
            this.SetParamObj(map, prefix + "LocalDiskInfo.", this.LocalDiskInfo);
            this.SetParamObj(map, prefix + "DiskCountRange.", this.DiskCountRange);
            this.SetParamSimple(map, prefix + "HSsdAvailable", this.HSsdAvailable);
            this.SetParamSimple(map, prefix + "HSsdSoldOutReason", this.HSsdSoldOutReason);
            this.SetParamObj(map, prefix + "HSsdDiskSizeRange.", this.HSsdDiskSizeRange);
            this.SetParamSimple(map, prefix + "ThroughputAvailable", this.ThroughputAvailable);
            this.SetParamSimple(map, prefix + "ThroughputSoldOutReason", this.ThroughputSoldOutReason);
            this.SetParamObj(map, prefix + "ThroughputDiskSizeRange.", this.ThroughputDiskSizeRange);
            this.SetParamSimple(map, prefix + "BigDataAvailable", this.BigDataAvailable);
            this.SetParamSimple(map, prefix + "BigDataSoldOutReason", this.BigDataSoldOutReason);
            this.SetParamObj(map, prefix + "BigDataDiskSizeRange.", this.BigDataDiskSizeRange);
            this.SetParamSimple(map, prefix + "HighIOAvailable", this.HighIOAvailable);
            this.SetParamSimple(map, prefix + "HighIOSoldOutReason", this.HighIOSoldOutReason);
            this.SetParamObj(map, prefix + "HighIODiskSizeRange.", this.HighIODiskSizeRange);
            this.SetParamSimple(map, prefix + "BssdAvailable", this.BssdAvailable);
            this.SetParamSimple(map, prefix + "BssdSoldOutReason", this.BssdSoldOutReason);
            this.SetParamObj(map, prefix + "BssdDiskSizeRange.", this.BssdDiskSizeRange);
            this.SetParamObj(map, prefix + "GpuInfo.", this.GpuInfo);
        }
    }
}

