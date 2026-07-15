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

    public class NodeTypeDiskSizeRange : AbstractModel
    {
        
        /// <summary>
        /// 机器类型
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 磁盘最小值
        /// </summary>
        [JsonProperty("Min")]
        public ulong? Min{ get; set; }

        /// <summary>
        /// 中刻度值
        /// </summary>
        [JsonProperty("Med")]
        public ulong? Med{ get; set; }

        /// <summary>
        /// 磁盘最大值
        /// </summary>
        [JsonProperty("Max")]
        public ulong? Max{ get; set; }

        /// <summary>
        /// 磁盘最小个数
        /// </summary>
        [JsonProperty("DiskCountMin")]
        public ulong? DiskCountMin{ get; set; }

        /// <summary>
        /// 磁盘最大个数
        /// </summary>
        [JsonProperty("DiskCountMax")]
        public ulong? DiskCountMax{ get; set; }

        /// <summary>
        /// 是否加密盘
        /// </summary>
        [JsonProperty("DiskEncrypt")]
        public ulong? DiskEncrypt{ get; set; }

        /// <summary>
        /// 是否增强
        /// </summary>
        [JsonProperty("DiskEnhance")]
        public ulong? DiskEnhance{ get; set; }

        /// <summary>
        /// 是否lvm
        /// </summary>
        [JsonProperty("IsLvm")]
        public ulong? IsLvm{ get; set; }

        /// <summary>
        /// 是否本地盘
        /// </summary>
        [JsonProperty("IsLocalDiskType")]
        public bool? IsLocalDiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Med", this.Med);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "DiskCountMin", this.DiskCountMin);
            this.SetParamSimple(map, prefix + "DiskCountMax", this.DiskCountMax);
            this.SetParamSimple(map, prefix + "DiskEncrypt", this.DiskEncrypt);
            this.SetParamSimple(map, prefix + "DiskEnhance", this.DiskEnhance);
            this.SetParamSimple(map, prefix + "IsLvm", this.IsLvm);
            this.SetParamSimple(map, prefix + "IsLocalDiskType", this.IsLocalDiskType);
        }
    }
}

