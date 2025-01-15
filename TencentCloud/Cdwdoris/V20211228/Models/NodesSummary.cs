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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodesSummary : AbstractModel
    {
        
        /// <summary>
        /// 机型，如 S1
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 节点数目
        /// </summary>
        [JsonProperty("NodeSize")]
        public long? NodeSize{ get; set; }

        /// <summary>
        /// cpu核数，单位个
        /// </summary>
        [JsonProperty("Core")]
        public long? Core{ get; set; }

        /// <summary>
        /// 内存大小，单位G
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 磁盘大小，单位G
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 磁盘描述
        /// </summary>
        [JsonProperty("DiskDesc")]
        public string DiskDesc{ get; set; }

        /// <summary>
        /// 挂载云盘信息
        /// </summary>
        [JsonProperty("AttachCBSSpec")]
        public AttachCBSSpec AttachCBSSpec{ get; set; }

        /// <summary>
        /// 子产品名称
        /// </summary>
        [JsonProperty("SubProductType")]
        public string SubProductType{ get; set; }

        /// <summary>
        /// 规格核数
        /// </summary>
        [JsonProperty("SpecCore")]
        public long? SpecCore{ get; set; }

        /// <summary>
        /// 规格内存
        /// </summary>
        [JsonProperty("SpecMemory")]
        public long? SpecMemory{ get; set; }

        /// <summary>
        /// 磁盘大小
        /// </summary>
        [JsonProperty("DiskCount")]
        public long? DiskCount{ get; set; }

        /// <summary>
        /// 是否加密
        /// </summary>
        [JsonProperty("Encrypt")]
        public long? Encrypt{ get; set; }

        /// <summary>
        /// 最大磁盘
        /// </summary>
        [JsonProperty("MaxDiskSize")]
        public long? MaxDiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "NodeSize", this.NodeSize);
            this.SetParamSimple(map, prefix + "Core", this.Core);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskDesc", this.DiskDesc);
            this.SetParamObj(map, prefix + "AttachCBSSpec.", this.AttachCBSSpec);
            this.SetParamSimple(map, prefix + "SubProductType", this.SubProductType);
            this.SetParamSimple(map, prefix + "SpecCore", this.SpecCore);
            this.SetParamSimple(map, prefix + "SpecMemory", this.SpecMemory);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "MaxDiskSize", this.MaxDiskSize);
        }
    }
}

