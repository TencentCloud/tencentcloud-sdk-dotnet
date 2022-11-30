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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// 规格名称，例如“SCH1"
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存大小，单位G
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// 分类标记，STANDARD/BIGDATA/HIGHIO分别表示标准型/大数据型/高IO
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 系统盘描述信息
        /// </summary>
        [JsonProperty("SystemDisk")]
        public DiskSpec SystemDisk{ get; set; }

        /// <summary>
        /// 数据盘描述信息
        /// </summary>
        [JsonProperty("DataDisk")]
        public DiskSpec DataDisk{ get; set; }

        /// <summary>
        /// 最大节点数目限制
        /// </summary>
        [JsonProperty("MaxNodeSize")]
        public long? MaxNodeSize{ get; set; }

        /// <summary>
        /// 是否可用，false代表售罄
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// 规格描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComputeSpecDesc")]
        public string ComputeSpecDesc{ get; set; }

        /// <summary>
        /// 规格名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 库存数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceQuota")]
        public long? InstanceQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamSimple(map, prefix + "MaxNodeSize", this.MaxNodeSize);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "ComputeSpecDesc", this.ComputeSpecDesc);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "InstanceQuota", this.InstanceQuota);
        }
    }
}

