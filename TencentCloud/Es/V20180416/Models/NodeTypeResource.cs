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

    public class NodeTypeResource : AbstractModel
    {
        
        /// <summary>
        /// <p>规格名称</p>
        /// </summary>
        [JsonProperty("NodeTypeName")]
        public string NodeTypeName{ get; set; }

        /// <summary>
        /// <p>是否可售</p>
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// <p>规格信息</p>
        /// </summary>
        [JsonProperty("NodeTypeInfo")]
        public NodeTypeInfo NodeTypeInfo{ get; set; }

        /// <summary>
        /// <p>SSD盘是否可售</p>
        /// </summary>
        [JsonProperty("SsdAvailable")]
        public bool? SsdAvailable{ get; set; }

        /// <summary>
        /// <p>SSD磁盘取值范围</p>
        /// </summary>
        [JsonProperty("SsdDiskSizeRange")]
        public DiskSizeRange SsdDiskSizeRange{ get; set; }

        /// <summary>
        /// <p>SSD机型售罄原因</p>
        /// </summary>
        [JsonProperty("SsdSoldOutReason")]
        public string SsdSoldOutReason{ get; set; }

        /// <summary>
        /// <p>SSD云硬盘售罄明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsdSoldOutDetail")]
        public FamilyResourceStat[] SsdSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>SATA盘是否可售</p>
        /// </summary>
        [JsonProperty("SataAvailable")]
        public bool? SataAvailable{ get; set; }

        /// <summary>
        /// <p>SATA磁盘取值范围</p>
        /// </summary>
        [JsonProperty("SataDiskSizeRange")]
        public DiskSizeRange SataDiskSizeRange{ get; set; }

        /// <summary>
        /// <p>SATA机型售罄原因</p>
        /// </summary>
        [JsonProperty("SataSoldOutReason")]
        public string SataSoldOutReason{ get; set; }

        /// <summary>
        /// <p>高性能云硬盘售罄明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SataSoldOutDetail")]
        public FamilyResourceStat[] SataSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>本地盘信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDiskInfo")]
        public LocalDiskInfo LocalDiskInfo{ get; set; }

        /// <summary>
        /// <p>云盘块数取值范围</p>
        /// </summary>
        [JsonProperty("DiskCountRange")]
        public DiskCountRange DiskCountRange{ get; set; }

        /// <summary>
        /// <p>HSSD盘是否可售</p>
        /// </summary>
        [JsonProperty("HSsdAvailable")]
        public bool? HSsdAvailable{ get; set; }

        /// <summary>
        /// <p>HSSD磁盘取值范围</p>
        /// </summary>
        [JsonProperty("HSsdDiskSizeRange")]
        public DiskSizeRange HSsdDiskSizeRange{ get; set; }

        /// <summary>
        /// <p>HSSD机型售罄原因</p>
        /// </summary>
        [JsonProperty("HSsdSoldOutReason")]
        public string HSsdSoldOutReason{ get; set; }

        /// <summary>
        /// <p>增强型SSD售罄明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HSsdSoldOutDetail")]
        public FamilyResourceStat[] HSsdSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>Throughput盘是否可售</p>
        /// </summary>
        [JsonProperty("ThroughputAvailable")]
        public bool? ThroughputAvailable{ get; set; }

        /// <summary>
        /// <p>Throughput磁盘取值范围</p>
        /// </summary>
        [JsonProperty("ThroughputDiskSizeRange")]
        public DiskSizeRange ThroughputDiskSizeRange{ get; set; }

        /// <summary>
        /// <p>Throughput机型售罄原因</p>
        /// </summary>
        [JsonProperty("ThroughputSoldOutReason")]
        public string ThroughputSoldOutReason{ get; set; }

        /// <summary>
        /// <p>吞吐型云硬盘售罄</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThroughputSoldOutDetail")]
        public FamilyResourceStat[] ThroughputSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>BigData盘是否可售</p>
        /// </summary>
        [JsonProperty("BigDataAvailable")]
        public bool? BigDataAvailable{ get; set; }

        /// <summary>
        /// <p>BigData磁盘取值范围</p>
        /// </summary>
        [JsonProperty("BigDataDiskSizeRange")]
        public DiskSizeRange BigDataDiskSizeRange{ get; set; }

        /// <summary>
        /// <p>BigData盘售罄原因</p>
        /// </summary>
        [JsonProperty("BigDataSoldOutReason")]
        public string BigDataSoldOutReason{ get; set; }

        /// <summary>
        /// <p>大数据型云硬盘售罄明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BigDataSoldOutDetail")]
        public FamilyResourceStat[] BigDataSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>HighIO盘是否可售</p>
        /// </summary>
        [JsonProperty("HighIOAvailable")]
        public bool? HighIOAvailable{ get; set; }

        /// <summary>
        /// <p>HighIO盘售罄原因</p>
        /// </summary>
        [JsonProperty("HighIOSoldOutReason")]
        public string HighIOSoldOutReason{ get; set; }

        /// <summary>
        /// <p>HighIO磁盘取值范围</p>
        /// </summary>
        [JsonProperty("HighIODiskSizeRange")]
        public DiskSizeRange HighIODiskSizeRange{ get; set; }

        /// <summary>
        /// <p>高IO型云硬盘售罄明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighIOSoldOutDetail")]
        public FamilyResourceStat[] HighIOSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>Bssd盘是否可售</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdAvailable")]
        public bool? BssdAvailable{ get; set; }

        /// <summary>
        /// <p>Bssd盘取值范围</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdDiskSizeRange")]
        public DiskSizeRange BssdDiskSizeRange{ get; set; }

        /// <summary>
        /// <p>Bssd盘售罄原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdSoldOutReason")]
        public string BssdSoldOutReason{ get; set; }

        /// <summary>
        /// <p>通用型SSD云硬盘售罄明细</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BssdSoldOutDetail")]
        public FamilyResourceStat[] BssdSoldOutDetail{ get; set; }

        /// <summary>
        /// <p>节点Gpu信息</p>
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
            this.SetParamSimple(map, prefix + "SsdSoldOutReason", this.SsdSoldOutReason);
            this.SetParamArrayObj(map, prefix + "SsdSoldOutDetail.", this.SsdSoldOutDetail);
            this.SetParamSimple(map, prefix + "SataAvailable", this.SataAvailable);
            this.SetParamObj(map, prefix + "SataDiskSizeRange.", this.SataDiskSizeRange);
            this.SetParamSimple(map, prefix + "SataSoldOutReason", this.SataSoldOutReason);
            this.SetParamArrayObj(map, prefix + "SataSoldOutDetail.", this.SataSoldOutDetail);
            this.SetParamObj(map, prefix + "LocalDiskInfo.", this.LocalDiskInfo);
            this.SetParamObj(map, prefix + "DiskCountRange.", this.DiskCountRange);
            this.SetParamSimple(map, prefix + "HSsdAvailable", this.HSsdAvailable);
            this.SetParamObj(map, prefix + "HSsdDiskSizeRange.", this.HSsdDiskSizeRange);
            this.SetParamSimple(map, prefix + "HSsdSoldOutReason", this.HSsdSoldOutReason);
            this.SetParamArrayObj(map, prefix + "HSsdSoldOutDetail.", this.HSsdSoldOutDetail);
            this.SetParamSimple(map, prefix + "ThroughputAvailable", this.ThroughputAvailable);
            this.SetParamObj(map, prefix + "ThroughputDiskSizeRange.", this.ThroughputDiskSizeRange);
            this.SetParamSimple(map, prefix + "ThroughputSoldOutReason", this.ThroughputSoldOutReason);
            this.SetParamArrayObj(map, prefix + "ThroughputSoldOutDetail.", this.ThroughputSoldOutDetail);
            this.SetParamSimple(map, prefix + "BigDataAvailable", this.BigDataAvailable);
            this.SetParamObj(map, prefix + "BigDataDiskSizeRange.", this.BigDataDiskSizeRange);
            this.SetParamSimple(map, prefix + "BigDataSoldOutReason", this.BigDataSoldOutReason);
            this.SetParamArrayObj(map, prefix + "BigDataSoldOutDetail.", this.BigDataSoldOutDetail);
            this.SetParamSimple(map, prefix + "HighIOAvailable", this.HighIOAvailable);
            this.SetParamSimple(map, prefix + "HighIOSoldOutReason", this.HighIOSoldOutReason);
            this.SetParamObj(map, prefix + "HighIODiskSizeRange.", this.HighIODiskSizeRange);
            this.SetParamArrayObj(map, prefix + "HighIOSoldOutDetail.", this.HighIOSoldOutDetail);
            this.SetParamSimple(map, prefix + "BssdAvailable", this.BssdAvailable);
            this.SetParamObj(map, prefix + "BssdDiskSizeRange.", this.BssdDiskSizeRange);
            this.SetParamSimple(map, prefix + "BssdSoldOutReason", this.BssdSoldOutReason);
            this.SetParamArrayObj(map, prefix + "BssdSoldOutDetail.", this.BssdSoldOutDetail);
            this.SetParamObj(map, prefix + "GpuInfo.", this.GpuInfo);
        }
    }
}

