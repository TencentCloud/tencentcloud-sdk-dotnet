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

    public class ResourceNodeSpec : AbstractModel
    {
        
        /// <summary>
        /// 节点类型，“DATA"数据节点，”COMMON" zookeeper节点
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 节点规格名称，例如 “SCH1","SCH2”等
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 节点数目
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 磁盘规格描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskSpec")]
        public ResourceNodeDiskSpec DiskSpec{ get; set; }

        /// <summary>
        /// 云盘是否加密，0不加密/1加密  默认为0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Encrypt")]
        public ulong? Encrypt{ get; set; }

        /// <summary>
        /// 额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public SpecExtra Extra{ get; set; }

        /// <summary>
        /// 挂载云盘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachCBSSpec")]
        public ResourceNodeDiskSpec AttachCBSSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamObj(map, prefix + "DiskSpec.", this.DiskSpec);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamObj(map, prefix + "Extra.", this.Extra);
            this.SetParamObj(map, prefix + "AttachCBSSpec.", this.AttachCBSSpec);
        }
    }
}

