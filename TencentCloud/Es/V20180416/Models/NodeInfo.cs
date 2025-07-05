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

    public class NodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 节点数量
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点类型<li>hotData: 热数据节点</li>
        /// <li>warmData: 冷数据节点</li>
        /// <li>dedicatedMaster: 专用主节点</li>
        /// 默认值为hotData
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 节点磁盘类型<li>CLOUD_SSD：SSD云硬盘</li><li>CLOUD_PREMIUM：高硬能云硬盘</li>默认值CLOUD_SSD
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 节点磁盘容量（单位GB）
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 节点本地盘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDiskInfo")]
        public LocalDiskInfo LocalDiskInfo{ get; set; }

        /// <summary>
        /// 节点磁盘块数
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// 节点磁盘是否加密 0: 不加密，1: 加密；默认不加密
        /// </summary>
        [JsonProperty("DiskEncrypt")]
        public ulong? DiskEncrypt{ get; set; }

        /// <summary>
        /// cpu数目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// 内存大小，单位GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// /
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskEnhance")]
        public long? DiskEnhance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamObj(map, prefix + "LocalDiskInfo.", this.LocalDiskInfo);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "DiskEncrypt", this.DiskEncrypt);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskEnhance", this.DiskEnhance);
        }
    }
}

