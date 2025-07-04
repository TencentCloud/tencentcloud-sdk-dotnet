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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PriceResource : AbstractModel
    {
        
        /// <summary>
        /// 需要的规格
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 硬盘类型
        /// </summary>
        [JsonProperty("StorageType")]
        public ulong? StorageType{ get; set; }

        /// <summary>
        /// 硬盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 系统盘大小
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// 内存大小
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// 核心数量
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 硬盘大小
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 云盘列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiDisks")]
        public MultiDisk[] MultiDisks{ get; set; }

        /// <summary>
        /// 磁盘数量
        /// </summary>
        [JsonProperty("DiskCnt")]
        public long? DiskCnt{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 磁盘数量
        /// </summary>
        [JsonProperty("DiskNum")]
        public long? DiskNum{ get; set; }

        /// <summary>
        /// 本地盘的数量
        /// </summary>
        [JsonProperty("LocalDiskNum")]
        public long? LocalDiskNum{ get; set; }

        /// <summary>
        /// GPU信息
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamArrayObj(map, prefix + "MultiDisks.", this.MultiDisks);
            this.SetParamSimple(map, prefix + "DiskCnt", this.DiskCnt);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DiskNum", this.DiskNum);
            this.SetParamSimple(map, prefix + "LocalDiskNum", this.LocalDiskNum);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
        }
    }
}

