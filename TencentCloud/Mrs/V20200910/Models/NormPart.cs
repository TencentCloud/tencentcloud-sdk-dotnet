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

    public class NormPart : AbstractModel
    {
        
        /// <summary>
        /// 部位值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Part")]
        public string Part{ get; set; }

        /// <summary>
        /// 部位方向
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartDirection")]
        public string PartDirection{ get; set; }

        /// <summary>
        /// 组织值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tissue")]
        public string Tissue{ get; set; }

        /// <summary>
        /// 组织方向
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TissueDirection")]
        public string TissueDirection{ get; set; }

        /// <summary>
        /// 上级部位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Upper")]
        public string Upper{ get; set; }

        /// <summary>
        /// 部位详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartDetail")]
        [System.Obsolete]
        public PartDesc PartDetail{ get; set; }

        /// <summary>
        /// 部位详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartDetailList")]
        public PartDesc[] PartDetailList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Part", this.Part);
            this.SetParamSimple(map, prefix + "PartDirection", this.PartDirection);
            this.SetParamSimple(map, prefix + "Tissue", this.Tissue);
            this.SetParamSimple(map, prefix + "TissueDirection", this.TissueDirection);
            this.SetParamSimple(map, prefix + "Upper", this.Upper);
            this.SetParamObj(map, prefix + "PartDetail.", this.PartDetail);
            this.SetParamArrayObj(map, prefix + "PartDetailList.", this.PartDetailList);
        }
    }
}

