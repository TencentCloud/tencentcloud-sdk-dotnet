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

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// 节点规格描述，如CVM.SA2。
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 取值范围:
        /// "LOCAL_SSD"   3     //本地SSD 
        /// "CLOUD_SSD"   4     //云SSD 
        /// "CLOUD_PREMIUM"  5  //高效云盘
        /// "CLOUD_HSSD"   6    //增强型SSD云硬盘 
        /// "CLOUD_THROUGHPUT" 11//吞吐型云硬盘 
        /// "CLOUD_TSSD"  12     //极速型SSD云硬盘 
        /// "CLOUD_BSSD"    13   //通用型SSD云硬盘 
        /// "CLOUD_BIGDATA" 14   //大数据型云硬盘
        /// "CLOUD_HIGHIO"  15   //高IO型云硬盘 
        /// 
        /// 该类型字段为无效字段，实际系统盘类型会根据数据盘类型和节点类型判断，如果节点支持所选的数据盘类型，系统盘类型会跟数据盘保持一致，建议使用CreateCluster接口
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// 数据盘类型 取值范围：
        /// 
        /// CLOUD_SSD：表示云SSD。
        /// 
        /// CLOUD_PREMIUM：表示高效云盘。
        /// 
        /// CLOUD_BASIC：表示云硬盘。
        /// 
        /// LOCAL_BASIC：表示本地盘。
        /// 
        /// LOCAL_SSD：表示本地SSD。
        /// 
        /// CLOUD_HSSD：表示增强型SSD云硬盘。
        /// 
        /// CLOUD_THROUGHPUT：表示吞吐型云硬盘。
        /// 
        /// CLOUD_TSSD：表示极速型SSD云硬盘。
        /// 
        /// CLOUD_BIGDATA：表示大数据型云硬盘。
        /// 
        /// CLOUD_HIGHIO：表示高IO型云硬盘。
        /// 
        /// CLOUD_BSSD：表示通用型SSD云硬盘。
        /// 
        /// REMOTE_SSD：表示远端SSD盘。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 内存容量,单位为M
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// CPU核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 数据盘容量
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 系统盘容量
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// 云盘列表，当数据盘为一块云盘时，直接使用DiskType和DiskSize参数，超出部分使用MultiDisks
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiDisks")]
        public MultiDisk[] MultiDisks{ get; set; }

        /// <summary>
        /// 需要绑定的标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 规格类型，如S2.MEDIUM8
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 本地盘数量，该字段已废弃
        /// </summary>
        [JsonProperty("LocalDiskNum")]
        public ulong? LocalDiskNum{ get; set; }

        /// <summary>
        /// 本地盘数量，如2
        /// </summary>
        [JsonProperty("DiskNum")]
        public ulong? DiskNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamArrayObj(map, prefix + "MultiDisks.", this.MultiDisks);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "LocalDiskNum", this.LocalDiskNum);
            this.SetParamSimple(map, prefix + "DiskNum", this.DiskNum);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
        }
    }
}

