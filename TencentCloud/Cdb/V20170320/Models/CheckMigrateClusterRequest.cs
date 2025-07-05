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

    public class CheckMigrateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例 CPU 核数。当 InstanceId 为主实例时必传。
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 实例内存大小，单位：MB。当 InstanceId 为主实例时必传。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例硬盘大小，单位：GB。
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// 磁盘类型。 CLOUD_SSD: SSD 云硬盘; CLOUD_HSSD: 增强型 SSD 云硬盘。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 云盘版节点拓扑配置。当 InstanceId 为主实例时必传。
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }

        /// <summary>
        /// 迁移实例类型。支持值包括： "CLOUD_NATIVE_CLUSTER" - 标准型云盘版实例， "CLOUD_NATIVE_CLUSTER_EXCLUSIVE" - 加强型云盘版实例。
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 只读实例信息。
        /// </summary>
        [JsonProperty("RoInfo")]
        public MigrateClusterRoInfo[] RoInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamObj(map, prefix + "ClusterTopology.", this.ClusterTopology);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamArrayObj(map, prefix + "RoInfo.", this.RoInfo);
        }
    }
}

