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
        /// <p>节点规格描述，如CVM.SA2。</p>
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>取值范围:<br>&quot;LOCAL_SSD&quot;   3     //本地SSD<br>&quot;CLOUD_SSD&quot;   4     //云SSD<br>&quot;CLOUD_PREMIUM&quot;  5  //高效云盘<br>&quot;CLOUD_HSSD&quot;   6    //增强型SSD云硬盘<br>&quot;CLOUD_THROUGHPUT&quot; 11//吞吐型云硬盘<br>&quot;CLOUD_TSSD&quot;  12     //极速型SSD云硬盘<br>&quot;CLOUD_BSSD&quot;    13   //通用型SSD云硬盘<br>&quot;CLOUD_BIGDATA&quot; 14   //大数据型云硬盘<br>&quot;CLOUD_HIGHIO&quot;  15   //高IO型云硬盘 </p><p>该类型字段为无效字段，实际系统盘类型会根据数据盘类型和节点类型判断，如果节点支持所选的数据盘类型，系统盘类型会跟数据盘保持一致，建议使用CreateCluster接口</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// <p>数据盘类型 取值范围：</p><p>CLOUD_SSD：表示云SSD。</p><p>CLOUD_PREMIUM：表示高效云盘。</p><p>CLOUD_BASIC：表示云硬盘。</p><p>LOCAL_BASIC：表示本地盘。</p><p>LOCAL_SSD：表示本地SSD。</p><p>CLOUD_HSSD：表示增强型SSD云硬盘。</p><p>CLOUD_THROUGHPUT：表示吞吐型云硬盘。</p><p>CLOUD_TSSD：表示极速型SSD云硬盘。</p><p>CLOUD_BIGDATA：表示大数据型云硬盘。</p><p>CLOUD_HIGHIO：表示高IO型云硬盘。</p><p>CLOUD_BSSD：表示通用型SSD云硬盘。</p><p>REMOTE_SSD：表示远端SSD盘。</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>内存容量,单位为M</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>CPU核数</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>数据盘容量</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>系统盘容量</p>
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// <p>云盘列表，当数据盘为一块云盘时，直接使用DiskType和DiskSize参数，超出部分使用MultiDisks</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiDisks")]
        public MultiDisk[] MultiDisks{ get; set; }

        /// <summary>
        /// <p>需要绑定的标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>规格类型，如S2.MEDIUM8</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>本地盘数量，该字段已废弃</p>
        /// </summary>
        [JsonProperty("LocalDiskNum")]
        public ulong? LocalDiskNum{ get; set; }

        /// <summary>
        /// <p>本地盘数量，如2</p>
        /// </summary>
        [JsonProperty("DiskNum")]
        public ulong? DiskNum{ get; set; }

        /// <summary>
        /// <p>GPU信息</p>
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }

        /// <summary>
        /// <p>分区置放群组分区数</p>
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public long? PartitionNumber{ get; set; }


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
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
        }
    }
}

