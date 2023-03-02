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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndoscopyOrgan : AbstractModel
    {
        
        /// <summary>
        /// 部位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Part")]
        public Part Part{ get; set; }

        /// <summary>
        /// 原文位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Index")]
        public long?[] Index{ get; set; }

        /// <summary>
        /// 原文
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 部位别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartAlias")]
        public string PartAlias{ get; set; }

        /// <summary>
        /// 症状描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SymDescList")]
        public BlockInfo[] SymDescList{ get; set; }

        /// <summary>
        /// 坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Coords")]
        public Coord[] Coords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamArraySimple(map, prefix + "Index.", this.Index);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "PartAlias", this.PartAlias);
            this.SetParamArrayObj(map, prefix + "SymDescList.", this.SymDescList);
            this.SetParamArrayObj(map, prefix + "Coords.", this.Coords);
        }
    }
}

