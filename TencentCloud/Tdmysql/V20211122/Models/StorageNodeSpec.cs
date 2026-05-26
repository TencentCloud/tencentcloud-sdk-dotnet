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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageNodeSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>规格码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>存储节点CPU核数</p>
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>存储节点内存大小</p>
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>存储节点最大数量</p>
        /// </summary>
        [JsonProperty("StorageNodeMaxNum")]
        public long? StorageNodeMaxNum{ get; set; }

        /// <summary>
        /// <p>存储节点磁盘大小上限</p>
        /// </summary>
        [JsonProperty("StorageNodeMaxDisk")]
        public long? StorageNodeMaxDisk{ get; set; }

        /// <summary>
        /// <p>存储节点最小数量</p>
        /// </summary>
        [JsonProperty("StorageNodeMinNum")]
        public long? StorageNodeMinNum{ get; set; }

        /// <summary>
        /// <p>存储节点磁盘大小下限</p>
        /// </summary>
        [JsonProperty("StorageNodeMinDisk")]
        public long? StorageNodeMinDisk{ get; set; }

        /// <summary>
        /// <p>磁盘类型，CLOUD_HSSD增强型SSD,CLOUD_TCS本地SSD盘</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>存储节点默认磁盘大小，用于前端展示</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageNodeDefaultDisk")]
        public long? StorageNodeDefaultDisk{ get; set; }

        /// <summary>
        /// <p>规格支持计费模式列表</p>
        /// </summary>
        [JsonProperty("InstanceMode")]
        public string[] InstanceMode{ get; set; }

        /// <summary>
        /// <p>磁盘类型CLOUD_DISK：云盘LOCAL_DISK：本地盘</p>
        /// </summary>
        [JsonProperty("DiskTypeCategory")]
        public string DiskTypeCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "StorageNodeMaxNum", this.StorageNodeMaxNum);
            this.SetParamSimple(map, prefix + "StorageNodeMaxDisk", this.StorageNodeMaxDisk);
            this.SetParamSimple(map, prefix + "StorageNodeMinNum", this.StorageNodeMinNum);
            this.SetParamSimple(map, prefix + "StorageNodeMinDisk", this.StorageNodeMinDisk);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageNodeDefaultDisk", this.StorageNodeDefaultDisk);
            this.SetParamArraySimple(map, prefix + "InstanceMode.", this.InstanceMode);
            this.SetParamSimple(map, prefix + "DiskTypeCategory", this.DiskTypeCategory);
        }
    }
}

