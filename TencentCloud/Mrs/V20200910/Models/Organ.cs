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

    public class Organ : AbstractModel
    {
        
        /// <summary>
        /// 部位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Part")]
        public Part Part{ get; set; }

        /// <summary>
        /// 大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public Size[] Size{ get; set; }

        /// <summary>
        /// 包膜
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Envelope")]
        public BlockInfo Envelope{ get; set; }

        /// <summary>
        /// 边缘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Edge")]
        public BlockInfo Edge{ get; set; }

        /// <summary>
        /// 内部回声
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerEcho")]
        public BlockInfo InnerEcho{ get; set; }

        /// <summary>
        /// 腺体
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gland")]
        public BlockInfo Gland{ get; set; }

        /// <summary>
        /// 形状
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Shape")]
        public BlockInfo Shape{ get; set; }

        /// <summary>
        /// 厚度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Thickness")]
        public BlockInfo Thickness{ get; set; }

        /// <summary>
        /// 形态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShapeAttr")]
        public BlockInfo ShapeAttr{ get; set; }

        /// <summary>
        /// 血液cdfi
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CDFI")]
        public BlockInfo CDFI{ get; set; }

        /// <summary>
        /// 描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SymDesc")]
        public BlockInfo SymDesc{ get; set; }

        /// <summary>
        /// 大小状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SizeStatus")]
        public BlockInfo SizeStatus{ get; set; }

        /// <summary>
        /// 轮廓
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Outline")]
        public BlockInfo Outline{ get; set; }

        /// <summary>
        /// 结构
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Structure")]
        public BlockInfo Structure{ get; set; }

        /// <summary>
        /// 密度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Density")]
        public BlockInfo Density{ get; set; }

        /// <summary>
        /// 血管
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vas")]
        public BlockInfo Vas{ get; set; }

        /// <summary>
        /// 囊壁
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cysticwall")]
        public BlockInfo Cysticwall{ get; set; }

        /// <summary>
        /// 被膜
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Capsule")]
        public BlockInfo Capsule{ get; set; }

        /// <summary>
        /// 峡部厚度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsthmusThicknese")]
        public Size IsthmusThicknese{ get; set; }

        /// <summary>
        /// 内部回声分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerEchoDistribution")]
        public BlockInfo InnerEchoDistribution{ get; set; }

        /// <summary>
        /// 原文
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 原文位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Index")]
        public long?[] Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamArrayObj(map, prefix + "Size.", this.Size);
            this.SetParamObj(map, prefix + "Envelope.", this.Envelope);
            this.SetParamObj(map, prefix + "Edge.", this.Edge);
            this.SetParamObj(map, prefix + "InnerEcho.", this.InnerEcho);
            this.SetParamObj(map, prefix + "Gland.", this.Gland);
            this.SetParamObj(map, prefix + "Shape.", this.Shape);
            this.SetParamObj(map, prefix + "Thickness.", this.Thickness);
            this.SetParamObj(map, prefix + "ShapeAttr.", this.ShapeAttr);
            this.SetParamObj(map, prefix + "CDFI.", this.CDFI);
            this.SetParamObj(map, prefix + "SymDesc.", this.SymDesc);
            this.SetParamObj(map, prefix + "SizeStatus.", this.SizeStatus);
            this.SetParamObj(map, prefix + "Outline.", this.Outline);
            this.SetParamObj(map, prefix + "Structure.", this.Structure);
            this.SetParamObj(map, prefix + "Density.", this.Density);
            this.SetParamObj(map, prefix + "Vas.", this.Vas);
            this.SetParamObj(map, prefix + "Cysticwall.", this.Cysticwall);
            this.SetParamObj(map, prefix + "Capsule.", this.Capsule);
            this.SetParamObj(map, prefix + "IsthmusThicknese.", this.IsthmusThicknese);
            this.SetParamObj(map, prefix + "InnerEchoDistribution.", this.InnerEchoDistribution);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamArraySimple(map, prefix + "Index.", this.Index);
        }
    }
}

