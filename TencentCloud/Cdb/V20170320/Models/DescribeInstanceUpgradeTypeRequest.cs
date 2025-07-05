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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceUpgradeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 目标实例 CPU 的核数。为保证传入值有效，请使用 [DescribeCdbZoneConfig](https://cloud.tencent.com/document/product/236/80281) 获取实例可售卖的 CPU 值范围。
        /// </summary>
        [JsonProperty("DstCpu")]
        public float? DstCpu{ get; set; }

        /// <summary>
        /// 目标实例内存大小，单位：MB。为保证传入值有效，请使用 [DescribeCdbZoneConfig](https://cloud.tencent.com/document/product/236/80281) 获取实例可售卖的内存大小范围。
        /// </summary>
        [JsonProperty("DstMemory")]
        public ulong? DstMemory{ get; set; }

        /// <summary>
        /// 目标实例磁盘大小，单位：GB。为保证传入值有效，请使用 [DescribeCdbZoneConfig](https://cloud.tencent.com/document/product/236/80281) 获取实例可售卖的磁盘大小范围。
        /// </summary>
        [JsonProperty("DstDisk")]
        public ulong? DstDisk{ get; set; }

        /// <summary>
        /// 目标实例数据库版本。可选值：5.6，5.7，8.0。
        /// </summary>
        [JsonProperty("DstVersion")]
        public string DstVersion{ get; set; }

        /// <summary>
        /// 目标实例部署模型。默认为0，支持值包括：0 - 表示单可用区，1 - 表示多可用区。
        /// </summary>
        [JsonProperty("DstDeployMode")]
        public long? DstDeployMode{ get; set; }

        /// <summary>
        /// 目标实例复制类型，支持值包括：0 - 表示异步复制，1 - 表示半同步复制，2 - 表示强同步复制。
        /// </summary>
        [JsonProperty("DstProtectMode")]
        public long? DstProtectMode{ get; set; }

        /// <summary>
        /// 目标实例备机1可用区 ID。可使用 [DescribeCdbZoneConfig](https://cloud.tencent.com/document/product/236/80281) 获取可用区 ID。
        /// </summary>
        [JsonProperty("DstSlaveZone")]
        public long? DstSlaveZone{ get; set; }

        /// <summary>
        /// 目标实例备机2可用区 ID。可使用 [DescribeCdbZoneConfig](https://cloud.tencent.com/document/product/236/80281) 获取可用区 ID。
        /// </summary>
        [JsonProperty("DstBackupZone")]
        public long? DstBackupZone{ get; set; }

        /// <summary>
        /// 目标实例类型。支持值包括："CUSTOM" - 通用型实例，"EXCLUSIVE" - 独享型实例，"ONTKE" - ONTKE 单节点实例，"CLOUD_NATIVE_CLUSTER" - 云盘版标准型，"CLOUD_NATIVE_CLUSTER_EXCLUSIVE" - 云盘版加强型。
        /// </summary>
        [JsonProperty("DstCdbType")]
        public string DstCdbType{ get; set; }

        /// <summary>
        /// 目标实例主可用区 ID。可使用 [DescribeCdbZoneConfig](https://cloud.tencent.com/document/product/236/80281) 获取可用区 ID。
        /// </summary>
        [JsonProperty("DstZoneId")]
        public long? DstZoneId{ get; set; }

        /// <summary>
        /// 独享集群 CDB 实例的节点分布情况。
        /// </summary>
        [JsonProperty("NodeDistribution")]
        public NodeDistribution NodeDistribution{ get; set; }

        /// <summary>
        /// 集群版的节点拓扑配置。Nodeld信息可通过 [DescribeClusterInfo](https://cloud.tencent.com/document/api/236/105116) 接口获取。
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DstCpu", this.DstCpu);
            this.SetParamSimple(map, prefix + "DstMemory", this.DstMemory);
            this.SetParamSimple(map, prefix + "DstDisk", this.DstDisk);
            this.SetParamSimple(map, prefix + "DstVersion", this.DstVersion);
            this.SetParamSimple(map, prefix + "DstDeployMode", this.DstDeployMode);
            this.SetParamSimple(map, prefix + "DstProtectMode", this.DstProtectMode);
            this.SetParamSimple(map, prefix + "DstSlaveZone", this.DstSlaveZone);
            this.SetParamSimple(map, prefix + "DstBackupZone", this.DstBackupZone);
            this.SetParamSimple(map, prefix + "DstCdbType", this.DstCdbType);
            this.SetParamSimple(map, prefix + "DstZoneId", this.DstZoneId);
            this.SetParamObj(map, prefix + "NodeDistribution.", this.NodeDistribution);
            this.SetParamObj(map, prefix + "ClusterTopology.", this.ClusterTopology);
        }
    }
}

