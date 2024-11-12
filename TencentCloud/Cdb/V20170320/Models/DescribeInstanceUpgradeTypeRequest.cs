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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceUpgradeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 目标实例 CPU 的核数。
        /// </summary>
        [JsonProperty("DstCpu")]
        public float? DstCpu{ get; set; }

        /// <summary>
        /// 目标实例内存大小，单位：MB。
        /// </summary>
        [JsonProperty("DstMemory")]
        public ulong? DstMemory{ get; set; }

        /// <summary>
        /// 目标实例磁盘大小，单位：GB。
        /// </summary>
        [JsonProperty("DstDisk")]
        public ulong? DstDisk{ get; set; }

        /// <summary>
        /// 目标实例数据库版本。
        /// </summary>
        [JsonProperty("DstVersion")]
        public string DstVersion{ get; set; }

        /// <summary>
        /// 目标实例部署模型。
        /// </summary>
        [JsonProperty("DstDeployMode")]
        public long? DstDeployMode{ get; set; }

        /// <summary>
        /// 目标实例复制类型。
        /// </summary>
        [JsonProperty("DstProtectMode")]
        public long? DstProtectMode{ get; set; }

        /// <summary>
        /// 目标实例备机1可用区。
        /// </summary>
        [JsonProperty("DstSlaveZone")]
        public long? DstSlaveZone{ get; set; }

        /// <summary>
        /// 目标实例备机2可用区。
        /// </summary>
        [JsonProperty("DstBackupZone")]
        public long? DstBackupZone{ get; set; }

        /// <summary>
        /// 目标实例类型。
        /// </summary>
        [JsonProperty("DstCdbType")]
        public string DstCdbType{ get; set; }

        /// <summary>
        /// 目标实例主可用区。
        /// </summary>
        [JsonProperty("DstZoneId")]
        public long? DstZoneId{ get; set; }

        /// <summary>
        /// 独享集群 CDB 实例的节点分布情况。
        /// </summary>
        [JsonProperty("NodeDistribution")]
        public NodeDistribution NodeDistribution{ get; set; }

        /// <summary>
        /// 集群版的节点拓扑配置
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

